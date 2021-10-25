using System;
using System.Collections;
using System.Collections.ObjectModel;
using AnimalRegister.MVVM.Model;

namespace AnimalRegister
{
    public class MainViewModel
    {
        public ObservableCollection<MessageModel> Messages { get; set; }
        public ObservableCollection<ContactModel> Contacts { get; set; }

        public MainViewModel()
        {
            Messages = new ObservableCollection<MessageModel>();
            Contacts = new ObservableCollection<ContactModel>();

            Messages.Add(new MessageModel
            {
                Username = "Олег",
                UsernameColor = "#406aff",
                ImageSource = "https://i.imgur.com/yMWvLXd.png",
                Message = "test",
                Time = DateTime.Now,
                IsNativeOrigin = false,
                FirstMessage = true
            });

            Contacts.Add(new ContactModel
            {
                Username = "Добавить",
            });
            
            Contacts.Add(new ContactModel
            {
                Username = "Обновить",
            });
            
            Contacts.Add(new ContactModel
            {
                Username = "Удалить",
                
            });
        }
        
        
    }
}