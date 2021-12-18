using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using AnimalRegister.MVVM.Model.Controllers;

namespace AnimalRegister
{
    public partial class MainWindow : Window
    {
        private readonly List<long> ids = new List<long>();

        private bool isAnimal = true;

        public MainWindow()
        {
            InitializeComponent();
            UpdateGrid();
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
            var animals = new AnimalCardController().GetAllAnimalCards();
            foreach (var animalCardModel in animals)
            {
                ids.Add(animalCardModel.Id);
            }

            animalsGrid.ItemsSource = animals;
        }

        private void UpdateScheduleDataGrid()
        {
            ids.Clear();
            var schedules = new ScheduleCardController().GetAllScheduleCards();
            foreach (var scheduleCardModel in schedules)
            {
                ids.Add(scheduleCardModel.Id);
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
                var card = new Card(false, ids[animalsGrid.SelectedIndex]);
                card.ShowDialog();
                UpdateGrid();
            }
        }

        private void scheduleGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (scheduleGrid.SelectedIndex >= 0)
            {
                var card = new ScheduleCardCard(false, ids[scheduleGrid.SelectedIndex]);
                card.ShowDialog();
                UpdateGrid();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isAnimal)
            {
                var card = new Card(true);
                card.ShowDialog();
                UpdateGrid();
            }
            else
            {
                var card = new ScheduleCardCard(true);
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