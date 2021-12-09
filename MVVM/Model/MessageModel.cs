using System;

namespace AnimalRegister.MVVM.Model
{
    //todo Эти файлы в проекте не учавствуют, но трогать их пока не надо
    public class MessageModel
    {
        public string Username { get; set; }
        public string UsernameColor { get; set; }
        public string ImageSource { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
        public bool IsNativeOrigin { get; set; }
        public bool? FirstMessage { get; set; }
    }
}