using System.Collections.Generic;

namespace AnimalRegister.MVVM.Model.Mappers
{
    public static class LoginMapper
    {
        public static User GetUser(Dictionary<string, string> data)
        {
            return new User() {Login = data["login"], Password = data["password"]};
        }
        
        public static Dictionary<string, string> GetResult(User user)
        {
            var result = new Dictionary<string, string>
            {
                {"name", user.Name}, {"login", user.Login}, {"password", user.Password}
            };

            return result;
        }
    }
}