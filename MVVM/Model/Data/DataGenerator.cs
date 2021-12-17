using System.Collections.Generic;
using System;

namespace AnimalRegister.MVVM.Model
{
    public static class DataGenerator
    {
        public static Dictionary<string, string> GenerateLoginDataModel(string name = null, string login = null,
            string password = null) =>
            new()
            {
                {"name", name},
                {"login", login},
                {"password", password},
                {"validationStatus", null},
                {"message", null}
            };
        
        public static Dictionary<string, string> GenerateAnimalDataModel(
            string id,
            string name = null,
            DateTime dateCatch = default,
            string municipality = null,
            string locality = null,
            string category = null,
            string gender = null,
            string wool = null,
            string size = null,
            string mk = null,
            DateTime conclusion = default,
            DateTime validity = default,
            DateTime statusDate = default,
            string executor = null,
            string status = null,
            string localGovernment = null) =>
            new Dictionary<string, string>
            {
                {"Id", id},
                {"Name", name},
                {"DateOfCatch", dateCatch.ToString()},
                {"Municipality", municipality},
                {"Locality", locality},
                {"Category", category},
                {"Gender", gender},
                {"TypeOfWool", wool},
                {"Size", size},
                {"MK", mk},
                {"Conclusion", conclusion.ToString()},
                {"Validity", validity.ToString()},
                {"Executor", executor},
                {"LocalGovernment", localGovernment},
                {"Status", status},
                {"StatusDate", statusDate.ToString()},
                {"validationStatus", null},
                {"message", null}
            };
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