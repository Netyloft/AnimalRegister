using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using AnimalRegister.MVVM.Model;
using AnimalRegister.MVVM.Model.Controllers;

namespace AnimalRegister
{
    public partial class MainWindow : Window
    {
        private readonly List<int> ids = new List<int>();
        private bool isView;
        
        private bool isAnimal = true;

        public MainWindow(Dictionary<string, string> data)
        {
            InitializeComponent();
            if (data["RightsName"].Equals("View"))
            {
                BtnAdd.Visibility = Visibility.Collapsed;
                isView = true;
            }
                
            LoadUser(data);
            
            UpdateGrid();
        }
        
        private void LoadUser(Dictionary<string, string> data)
        {
            Name.Content = data["Name"];
            Rights.Content = data["RightsName"];
        }

        private void UpdateGrid()
        {
            if (isAnimal)
                UpdateAnimalDataGrid();
            else
                UpdateScheduleDataGrid();
        }

        private void UpdateAnimalDataGrid()
        {
            ids.Clear();
            var data = new AnimalCardController().GetAllAnimalCards();
            var animals = new List<AnimalCardModel>();
             foreach (var animalCardModel in data)
            {
                var animal = new AnimalCardModel()
                {
                    Id = int.Parse(animalCardModel["Id"]),
                    Catch = DateTime.Parse(animalCardModel["Catch"]),
                    Name = animalCardModel["Name"],
                    MK = animalCardModel["MK"],
                    Municipality = animalCardModel["Municipality.Name"],
                    Locality = animalCardModel["Locality"],
                    Status = animalCardModel["Status"]
                };
                ids.Add(animal.Id);
                animals.Add(animal);
                
            }

            animalsGrid.ItemsSource = animals;
        }

        private void UpdateScheduleDataGrid()
        {
            ids.Clear();
            var data = new ScheduleCardController().GetAllScheduleCards();
            var schedules = new List<ScheduleCardModel>();
            foreach (var scheduleCardModel in data)
            {
                var schedul = new ScheduleCardModel()
                {
                    Id = int.Parse(scheduleCardModel["Id"]),
                    Date = DateTime.Parse(scheduleCardModel["Date"]),
                    District = scheduleCardModel["District"],
                    Locality = scheduleCardModel["Locality"],
                    Status = scheduleCardModel["Status"]
                };
                ids.Add(schedul.Id);
                schedules.Add(schedul);
                
            }

            scheduleGrid.ItemsSource = schedules;
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


        private void CloseButtonClick(object sender, RoutedEventArgs e) => Application.Current.Shutdown();


        private void animalsGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (animalsGrid.SelectedIndex >= 0)
            {
                var card = new Card(false,isView, ids[animalsGrid.SelectedIndex]);
                card.ShowDialog();
                UpdateGrid();
            }
        }

        private void scheduleGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (scheduleGrid.SelectedIndex >= 0)
            {
                var card = new ScheduleCardCard(false,isView, ids[scheduleGrid.SelectedIndex]);
                card.ShowDialog();
                UpdateGrid();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAnimal)
            {
                var card = new Card(true,isView);
                card.ShowDialog();
                UpdateGrid();
            }
            else
            {
                var card = new ScheduleCardCard(true,isView);
                card.ShowDialog();
                UpdateGrid();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (isAnimal)
            {
                animalsGrid.Visibility = Visibility.Hidden;
                scheduleGrid.Visibility = Visibility.Visible;
                isAnimal = false;
            }
            else
            {
                animalsGrid.Visibility = Visibility.Visible;
                scheduleGrid.Visibility = Visibility.Hidden;
                isAnimal = true;
            }

            UpdateGrid();
        }

        private void s(object sender, SelectionChangedEventArgs e)
        {
        }
    }
}