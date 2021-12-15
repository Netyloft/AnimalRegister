using System;
using System.Collections.Generic;
using System.Reflection;
using System.Windows;
using System.Windows.Input;
using AnimalRegister.MVVM.Model;
using AnimalRegister.MVVM.Model.Controllers;
using AnimalRegister.MVVM.Model.NHibernate;
using AnimalRegister.MVVM.Model.Repositories;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;
using NHibernate.Tool.hbm2ddl;

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
            var login = Login.Text;
            var password = Password.Text;
            var data = DataGenerator.GenerateLoginDataModel(login:login, password:password);

            var result = new LoginController().Login(data);

            if (result["name"] == null)
            {
                MessageBox.Show("Пользователь с такими данными не зарегистрирован");
                return;
            }
                
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