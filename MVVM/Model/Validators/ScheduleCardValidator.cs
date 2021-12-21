using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalRegister.MVVM.Model.Validators
{
    class ScheduleCardValidator
    {
        public static Dictionary<string, string> Validate(Dictionary<string, string> data)
        {
            if (data["District"].Trim().Equals(""))
            {
                data["validationStatus"] = "INVALID";
                data["message"] = "Поле Район не заполнено";
                return data;
            }

            if (data["Locality"].Trim().Equals(""))
            {
                data["validationStatus"] = "INVALID";
                data["message"] = "Поле Город не заполнено";
                return data;
            }

            try
            {
                int.Parse(data["Organization.Id"]);
                int.Parse(data["Municipality.Id"]);
                DateTime.Parse(data["Date"]);
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
