using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalRegister.MVVM.Model.Validators
{
    class AnimalCardValidator
    {
        public static Dictionary<string, string> Validate(Dictionary<string, string> data)
        {
            if (data["Name"].Trim().Equals(""))
            {
                data["validationStatus"] = "INVALID";
                data["message"] = "Поле Имя не заполнено";
                return data;
            }

            if(data["Size"].Trim().Equals(""))
            {
                data["validationStatus"] = "INVALID";
                data["message"] = "Поле Размер не заполнено";
                return data;
            }

            if (data["TypeOfWool"].Trim().Equals(""))
            {
                data["validationStatus"] = "INVALID";
                data["message"] = "Поле Шерсть не заполнено";
                return data;
            }

            if (data["Gender"].Trim().Equals(""))
            {
                data["validationStatus"] = "INVALID";
                data["message"] = "Поле Пол не заполнено";
                return data;
            }

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