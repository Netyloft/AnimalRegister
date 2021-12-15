﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;
using AnimalRegister.MVVM.Model.Controllers;

namespace AnimalRegister
{
    public partial class MainWindow : Window
    {
        private readonly List<long> animalCardIds = new List<long>();

        public MainWindow()
        {
            InitializeComponent();

            var animals = new AnimalCardController().GetAllAnimalCards();
            foreach (var animalCardModel in animals)
            {
                animalCardIds.Add(animalCardModel.Id);
            }

            animalsGrid.ItemsSource = animals;
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


        private void animalsGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var card = new Card(animalCardIds[animalsGrid.SelectedIndex]);
            card.Show();
        }
    }
}