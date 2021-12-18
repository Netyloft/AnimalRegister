using System.Collections.Generic;

namespace AnimalRegister.MVVM.Model.Validators
{
    public static class LoginValidator
    {
        public static Dictionary<string, string> Validate(Dictionary<string, string> data)
        {
            try 
            {
                int.Parse(data["Id"]);
                int.Parse(data["Organization.Id"]);
                int.Parse(data["Municipality.Id"]);
            }
            catch(Exception e)
            {
                data["validationStatus"] = "INVALID";
                data["message"] = "Данные некорректно заполнены";
                return data;
            }
            data["validationStatus"] = "VALID";
            return data;
        }
    }
}