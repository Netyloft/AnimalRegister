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
using AnimalRegister.MVVM.Model.Controllers;

namespace AnimalRegister
{
    /// <summary>
    /// Логика взаимодействия для Card.xaml
    /// </summary>
    public partial class Card : Window
    {
        public Card(long id)
        {
            InitializeComponent();
            LoadCard(id);
        }

        private void LoadCard(long id)
        {
            var animal = new AnimalCardController().OpenAnimalCard(id);
            
            MK.Text = animal.MCNumber.ToString();
            Name.Text = animal.Name;
            Category.Text = animal.Category;
            Gender.Text = animal.Gender;
            Size.Text = animal.Size;
            TypeOfWool.Text = animal.TypeOfWool;
            Municipality.Text = animal.MunicipalityId.Name;
            Locality.Text = animal.Locality;
            Status.Text = animal.Status;
            StatusDate.Text = animal.StatusDate.ToString(CultureInfo.InvariantCulture);


        }
        
        private void BorderMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void ButtonMinimizeClick(object sender, RoutedEventArgs e) =>
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        

        private void WindowStateButtonClick(object sender, RoutedEventArgs e) =>
            Application.Current.MainWindow.WindowState = Application.Current.MainWindow.WindowState != WindowState.Maximized ? WindowState.Maximized : WindowState.Normal;
        

        private void CloseButtonClick(object sender, RoutedEventArgs e) => Close();
    }
}
