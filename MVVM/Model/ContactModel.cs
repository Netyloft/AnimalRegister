using System.Collections.ObjectModel;
using System.Linq;

namespace AnimalRegister.MVVM.Model
{
    //todo Эти файлы в проекте не учавствуют, но трогать их пока не надо

    public class ContactModel
    {
        public string Username { get; set; }
        public string ImageSource { get; set; }

        public ObservableCollection<MessageModel> Messages { get; set; }
        
        public string LastMessage => Messages.Last().Message;
    }
}