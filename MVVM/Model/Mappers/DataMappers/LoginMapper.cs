using System.Collections.Generic;

namespace AnimalRegister.MVVM.Model.Mappers
{
    public static class LoginMapper
    {
        public static User GetUser(Dictionary<string, string> data) =>
            new() {Login = data["login"], Password = data["password"]};
        
        
        public static Dictionary<string, string> GetResult(User user)
        {
            return DataGenerator.GenerateLoginDataModel(user.Name, user.Login, user.Password);
        }
    }
}