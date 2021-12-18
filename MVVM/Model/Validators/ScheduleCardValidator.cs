using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalRegister.MVVM.Model.Validators
{
    class ScheduleCardValidator
    {
        public static Dictionary<string, string> Validate(Dictionary<string, string> data)
        {
            try
            {
                int.Parse(data["Id"]);
                int.Parse(data["Organization.Id"]);
                int.Parse(data["Minicipality.Id"]);
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
