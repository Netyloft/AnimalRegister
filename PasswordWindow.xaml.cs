﻿using System.Windows;
using System.Windows.Input;

namespace AnimalRegister
{
    public partial class PasswordWindow : Window
    {
        public PasswordWindow()
        {
            InitializeComponent();
            
            Button.Click += Button_Click;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new MainWindow();
            Close();
            mainWindow.Show();
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
    }
}