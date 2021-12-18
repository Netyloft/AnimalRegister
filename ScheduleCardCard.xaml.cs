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
        private ScheduleCard _scheduleCard;

        public ScheduleCardCard(bool isCreate, long id = 1)
        {
            InitializeComponent();

            if (!isCreate)
                LoadCard(id);
            else
                CreateCard();
        }

        private void LoadCard(long id)
        {
            _scheduleCard = new ScheduleCardController().OpenScheduleCard(id);

            Date.Text = _scheduleCard.Date.ToString();
            District.Text = _scheduleCard.District;
            Locality.Text = _scheduleCard.Locality;
            Status.Text = _scheduleCard.Status;
            StatusDate.Text = _scheduleCard.StatusDate.ToString();
            OrganizationName.Text = _scheduleCard.OrganizationId.Name;
            LocalGovernment.Text = _scheduleCard.MunicipalitiesId.LocalGovernment;
        }

        private void CreateCard()
        {
            _scheduleCard = new ScheduleCard {MunicipalitiesId = new Municipalities(), OrganizationId = new Organization()};
        
            StatusDate.Text = DateTime.Now.ToString();
            Date.Text = DateTime.Now.ToString();
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
            _scheduleCard.Date = DateTime.Parse(Date.Text);
            _scheduleCard.District = District.Text;
            _scheduleCard.Locality = Locality.Text;
            _scheduleCard.Status = Status.Text;
            _scheduleCard.MunicipalitiesId.LocalGovernment = LocalGovernment.Text;
            _scheduleCard.Locality = Locality.Text;
            _scheduleCard.Status = Status.Text;
            _scheduleCard.StatusDate = DateTime.Parse(StatusDate.Text);
            _scheduleCard.OrganizationId.Name = OrganizationName.Text;

            _scheduleCard.MunicipalitiesId.Id = 1;
            _scheduleCard.OrganizationId.Id = 1;

            ScheduleCardController animalCardController = new ScheduleCardController();
            animalCardController.AddScheduleCard(_scheduleCard);

            Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ScheduleCardController scheduleCardController = new ScheduleCardController();

            if (_scheduleCard is not null)
                scheduleCardController.RemoveScheduleCard(_scheduleCard);


            Close();
        }
    }
}