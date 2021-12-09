using System.Collections.Generic;

namespace AnimalRegister.MVVM.Model.Validators
{
    public static class LoginValidator
    {
        //todo Сделать валидацию
        public static Dictionary<string, string> Validate(Dictionary<string, string> data)
        {
            
            data.Add("validationStatus", "Valid");

            return data;
        }
    }
}