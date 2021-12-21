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
    public partial class ScheduleCardCard : Window
    {
        private bool isCreate;
        private int id;

        public ScheduleCardCard(bool isCreate, bool rights, int id = -1)
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

        

        private void LoadCard(long id)
        {
            var data = new ScheduleCardController().OpenScheduleCard(id);

            Date.Text = data["Date"];
            District.Text = data["District"];
            Locality.Text = data["Locality"];
            Status.Text = data["Status"];
            StatusDate.Text = data["StatusDate"];
            OrganizationName.Text = data["Organization.Name"];
            LocalGovernment.Text = data["Municipalities.LocalGovernment"];
        }

        private void CreateCard()
        {
            isCreate = true;
            StatusDate.Text = DateTime.Now.ToString();
            Date.Text = DateTime.Now.ToString();
        }

        private void CloseButtonClick(object sender, RoutedEventArgs e) => Close();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var data = DataGenerator.GenerateScheduleDataModel(id.ToString(), Date.Text, District.Text, Locality.Text,
                Status.Text, StatusDate.Text, "1", OrganizationName.Text, "1", null, LocalGovernment.Text);

            ScheduleCardController animalCardController = new ScheduleCardController();
            Dictionary<string, string> res;

            if (isCreate)
                res = animalCardController.AddScheduleCard(data);
            else
                res = animalCardController.ChangeScheduleCard(data);

            if (res["validationStatus"] == "INVALID")
                MessageBox.Show(res["message"]);
            else
                Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ScheduleCardController scheduleCardController = new ScheduleCardController();

            if (!isCreate)
                scheduleCardController.RemoveScheduleCard(id);

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
    }
}