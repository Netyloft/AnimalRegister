using System.Collections.Generic;

namespace AnimalRegister.MVVM.Model.Mappers
{
    public static class LoginMapper
    {
        public static User GetUser(Dictionary<string, string> data) =>
            new() {Login = data["Login"], Password = data["Password"]};
        
        
        public static Dictionary<string, string> GetResult(User user)
        {
            return DataGenerator.GenerateLoginDataModel(user.Name, user.Login, user.Password);
        }
    }
}