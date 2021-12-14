using System.Collections.Generic;
using System;

namespace AnimalRegister.MVVM.Model
{
    public static class DataGenerator
    {
        public static Dictionary<string, string> GenerateLoginDataModel(string name = null, string login = null,
            string password = null) =>
            new Dictionary<string, string>
            {
                {"name", name},
                {"login", login},
                {"password", password},
                {"rights", null}, //todo Это поле возможно не нужно
                {"validationStatus", null},
                {"message", null}
            };
        //     public static Dictionary<string, string> GenerateAnimalDataModel(
        //         string name = null,
        //         DateTime dateCatch = null,
        //         string municipality = null,
        //         string locality = null,
        //         string category = null,
        //         string gender = null,
        //         string wool = null,
        //         string size = null,
        //         string mk = null,
        //         DateTime conclusion = null,
        //         DateTime validity = null,
        //         DateTime statusDate = null,
        //         string executor = null,
        //         string status = null,
        //         string localGoverment = null) =>
        //         new Dictionary<string, string>
        //         {
        //             {"name", name},
        //             {"dateCatch", dateCatch},
        //             {"municipality", municipality},
        //             {"locality", locality},
        //             {"category", category},
        //             {"gender", gender},
        //             {"wool", wool},
        //             {"size", size},
        //             {"mk", mk},
        //             {"conclusion", conclusion},
        //             {"validity", validity},
        //             {"executor", executor},
        //             {"localGovernment", localGoverment},
        //             {"status", status},
        //             {"statusDate", statusDate},
        //             {"validationStatus", null},
        //             {"message", null}
        //         };
        //
        //     public static Dictionary<string, string> GenerateScheduleDataModel(
        //         DateTime date = null,
        //         string district = null,
        //         string locality = null,
        //         string status = null,
        //         DateTime statusDate = null) =>
        //         new Dictionary<string, string>
        //         {
        //             {"date", date},
        //             {"district", district},
        //             {"locality", locality},
        //             {"status", status},
        //             {"statusDate", statusDate},
        //             {"validationStatus", null},
        //             {"message", null}
        //         };
        // }
    }
}