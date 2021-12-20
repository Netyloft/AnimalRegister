using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalRegister.MVVM.Model.Validators
{
    class AnimalCardValidator
    {
        public static Dictionary<string, string> Validate(Dictionary<string, string> data)
        {
            try
            {
                int.Parse(data["Organization.Id"]);
                int.Parse(data["Municipality.Id"]);
                DateTime.Parse(data["DateOfCatch"]);
                DateTime.Parse(data["Conclusion"]);
                DateTime.Parse(data["Validity"]);
                DateTime.Parse(data["StatusDate"]);
            }
            catch (Exception e)
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