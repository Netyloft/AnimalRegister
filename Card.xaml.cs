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
    /// <summary>
    /// Логика взаимодействия для Card.xaml
    /// </summary>
    public partial class Card : Window
    {
        private AnimalCard _animalCard;

        public Card(bool isCreate, long id = 1)
        {
            InitializeComponent();
            
            if(!isCreate)
                LoadCard(id);
            else
                CreateCard();
            
        }

        private void LoadCard(long id)
        {
            _animalCard = new AnimalCardController().OpenAnimalCard(id);

            MK.Text = _animalCard.MCNumber.ToString();
            Name.Text = _animalCard.Name; //
            Category.Text = _animalCard.Category;
            Gender.Text = _animalCard.Gender;
            Size.Text = _animalCard.Size;
            TypeOfWool.Text = _animalCard.TypeOfWool;
            Municipality.Text = _animalCard.MunicipalityId.Name;
            LocalGovernment.Text = _animalCard.MunicipalityId.LocalGovernment;
            Locality.Text = _animalCard.Locality;
            Status.Text = _animalCard.Status;
            StatusDate.Text = _animalCard.StatusDate.ToString();
            DateOfCatch.Text = _animalCard.DateOfCatch.ToString();
            Executor.Text = _animalCard.Executor;
            Organization.Text = _animalCard.OrganizationId.Name.ToString();
            Conclusion.Text = _animalCard.Conclusion.ToString();
            Validity.Text = _animalCard.Validity.ToString();
        }

        private void CreateCard()
        {
            
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_animalCard is null)
                _animalCard = new AnimalCard();

            _animalCard.MCNumber = MK.Text;
            _animalCard.Name = Name.Text;
            _animalCard.Category = Category.Text;
            _animalCard.Gender = Gender.Text;
            _animalCard.Size = Size.Text;
            _animalCard.TypeOfWool = TypeOfWool.Text;
            _animalCard.MunicipalityId.Name = Municipality.Text;
            _animalCard.MunicipalityId.LocalGovernment = LocalGovernment.Text;
            _animalCard.Locality = Locality.Text;
            _animalCard.Status = Status.Text;
            _animalCard.StatusDate = DateTime.Parse(StatusDate.Text);
            _animalCard.DateOfCatch = DateTime.Parse(DateOfCatch.Text);
            _animalCard.Executor = Executor.Text;
            _animalCard.OrganizationId.Name = Organization.Text;
            _animalCard.Conclusion = DateTime.Parse(Conclusion.Text);
            _animalCard.Validity = DateTime.Parse(Validity.Text);

            _animalCard.MunicipalityId.Id = 1;
            _animalCard.OrganizationId.Id = 1;
            
            AnimalCardController animalCardController = new AnimalCardController();
            animalCardController.AddAnimalCard(_animalCard);

            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AnimalCardController animalCardController = new AnimalCardController();
            
            if(_animalCard is not null)
                animalCardController.RemoveAnimalCard(_animalCard);

            
            Close();
        }
    }
}