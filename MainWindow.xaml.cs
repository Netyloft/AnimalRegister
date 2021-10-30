using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using AnimalRegister.MVVM.Model;

namespace AnimalRegister
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            var animals = new List<Animal>();
            animals.Add(new Animal() {Name = "Дима", Locality = "Тюмень", Municipality = "Тюмень", Status = "Статус", DateCapture = "День", DateStatus = "Два"});
            animals.Add(new Animal() {Name = "Дима", Locality = "Тюмень", Municipality = "Тюмень", Status = "Статус", DateCapture = "День", DateStatus = "Два"});
            animals.Add(new Animal() {Name = "Дима", Locality = "Тюмень", Municipality = "Тюмень", Status = "Статус", DateCapture = "День", DateStatus = "Два"});


            animalsGrid.ItemsSource = animals;
        }
        
        private void BorderMouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed) DragMove();
        }

        private void ButtonMinimizeClick(object sender, RoutedEventArgs e) =>
            Application.Current.MainWindow.WindowState = WindowState.Minimized;
        

        private void WindowStateButtonClick(object sender, RoutedEventArgs e) =>
            Application.Current.MainWindow.WindowState = Application.Current.MainWindow.WindowState != WindowState.Maximized ? WindowState.Maximized : WindowState.Normal;
        

        private void CloseButtonClick(object sender, RoutedEventArgs e) => Application.Current.Shutdown();

        private void ListView_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void phonesGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void ListView_SelectionChanged_1(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}