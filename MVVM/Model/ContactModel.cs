﻿using System.Collections.ObjectModel;
using System.Linq;

namespace AnimalRegister.MVVM.Model
{
    public class ContactModel
    {
        public string Username { get; set; }
        public string ImageSource { get; set; }

        public ObservableCollection<MessageModel> Messages { get; set; }
        
        public string LastMessage => Messages.Last().Message;
    }
}