using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AnimalRegister.MVVM.Model;
using AnimalRegister.MVVM.Model.Controllers;

namespace AnimalRegister
{
    public partial class Card : Window
    {
        private bool isCreate;
        private int id;

        public Card(bool isCreate, bool rights, int id = -1)
        {
            this.id = id;
            InitializeComponent();

            if (rights)
            {
                BtnSave.Visibility = Visibility.Collapsed;
                BtnDelete.Visibility = Visibility.Collapsed;
            }
                
            
            if (!isCreate)
                LoadCard(id);
            else
                CreateCard();
        }

        private void LoadCard(int id)
        {
            var data = new AnimalCardController().OpenAnimalCard(id);

            MK.Text = data["MCNumber"];
            Name.Text = data["Name"]; //
            Category.Text = data["Category"];
            Gender.Text = data["Gender"];
            Size.Text = data["Size"];
            TypeOfWool.Text = data["TypeOfWool"];
            Municipality.Text = data["Municipalities.Name"];
            LocalGovernment.Text = data["Municipalities.LocalGovernment"];
            Locality.Text = data["Locality"];
            Status.Text = data["Status"];
            StatusDate.Text = data["StatusDate"];
            DateOfCatch.Text = data["DateOfCatch"];
            Executor.Text = data["Executor"];
            Organization.Text = data["Organization.Name"];
            Conclusion.Text = data["Conclusion"];
            Validity.Text = data["Validity"];
        }

        private void CreateCard()
        {
            isCreate = true;

            StatusDate.Text = DateTime.Now.ToString();
            DateOfCatch.Text = DateTime.Now.ToString();
            Conclusion.Text = DateTime.Now.ToString();
            Validity.Text = DateTime.Now.ToString();
        }
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var data = DataGenerator.GenerateAnimalDataModel(id.ToString(), Status.Text, Category.Text, Name.Text, Size.Text,
                TypeOfWool.Text, Gender.Text, DateOfCatch.Text, Locality.Text,
                StatusDate.Text, (Municipality.SelectedIndex+1).ToString(), Municipality.Text, LocalGovernment.Text, (Organization.SelectedIndex+1).ToString(), Organization.Text, Executor.Text,
                Conclusion.Text, Validity.Text, MK.Text);


            AnimalCardController animalCardController = new AnimalCardController();
            Dictionary<string, string> res;

            if (isCreate)
                res = animalCardController.AddAnimalCard(data);
            else
                res = animalCardController.ChangeAnimalCard(data);
            
            if (res["validationStatus"] == "INVALID")
                MessageBox.Show(res["message"]);
            else
                Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AnimalCardController animalCardController = new AnimalCardController();

            if (!isCreate)
                animalCardController.RemoveAnimalCard(id);
            
            Close();
        }

        private void BorderMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void ButtonMinimizeClick(object sender, RoutedEventArgs e) =>
            Application.Current.MainWindow.WindowState = WindowState.Minimized;


        private void WindowStateButtonClick(object sender, RoutedEventArgs e) =>
            Application.Current.MainWindow.WindowState =
                Application.Current.MainWindow.WindowState != WindowState.Maximized
                    ? WindowState.Maximized
                    : WindowState.Normal;


        private void CloseButtonClick(object sender, RoutedEventArgs e) => Close();

        

        private void Municipality_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var list = new List<string>();
            list.Add("Тюменцы");
            list.Add("Курганцы");

            LocalGovernment.Text = list[Municipality.SelectedIndex];
        }

        
    }
}