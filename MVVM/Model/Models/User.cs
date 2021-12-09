namespace AnimalRegister.MVVM.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public UserRights Rights { get; set; }
    }
}