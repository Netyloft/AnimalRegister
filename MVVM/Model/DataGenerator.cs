﻿using System.Collections.Generic;

namespace AnimalRegister.MVVM.Model
{
    public static class DataGenerator
    {
        public static Dictionary<string, string> GenerateLoginDataModel() =>
            new Dictionary<string, string>
            {
                {"name", null},
                {"login", null},
                {"password", null},
                {"rights", null}, //todo Это поле возможно не нужно
                {"validationStatus", null},
                {"message", null}
            };
        
        public static Dictionary<string, string> GenerateAnimalDataModel() =>
            new Dictionary<string, string>
            {
                {"name", null},
                {"catch", null},
                {"municipality", null},
                {"locality", null},
                {"category", null},
                {"gender", null},
                {"size", null},
                {"mk", null},
                {"conclusion", null},
                {"validity", null},
                {"executor", null},
                {"localGovernment", null},
                {"executor", null},
                {"status", null},
                {"statusDate", null},
                {"validationStatus", null},
                {"message", null}
            };
        
        public static Dictionary<string, string> GenerateScheduleDataModel() =>
            new Dictionary<string, string>
            {
                {"date", null},
                {"district", null},
                {"locality", null},
                {"status", null},
                {"statusDate", null},
                {"validationStatus", null},
                {"message", null}
            };
    }
}