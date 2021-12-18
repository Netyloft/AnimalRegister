using System.Collections.Generic;
using System;

namespace AnimalRegister.MVVM.Model
{
    public static class DataGenerator
    {
        public static Dictionary<string, string> GenerateLoginDataModel(string Name = null, string Login = null,
            string Password = null) =>
            new()
            {
                {"Name", Name},
                {"Login", Login},
                {"Password", Password},
                {"validationStatus", null},
                {"message", null}
            };

        public static Dictionary<string, string> GenerateAnimalDataModel(
            string Id = null,
            string Status = null,
            string Category = null,
            string Name = null,
            string Size = null,
            string TypeOfWool = null,
            string Gender = null,
            string DateOfCatch = null, //это дата
            string Locality = null,
            string StatusDate = null, //это дата
            string MunicipalitiesId = null,
            string MunicipalitiesName = null,
            string MunicipalitiesLocalGovernment = null,
            string OrganizationId = null,
            string OrganizationName = null,
            string Executor = null,
            string Conclusion = null, //это дата
            string Validity = null, // это дата
            string MCNumber = null) =>
            new Dictionary<string, string>
            {
                {"Id", Id},
                {"Status", Status},
                {"Category", Category},
                {"Name", Name},
                {"Size", Size},
                {"TypeOfWool", TypeOfWool},
                {"Gender", Gender},
                {"DateOfCatch", DateOfCatch},
                {"Locality", Locality},
                {"StatusDate", StatusDate},
                {"Municipality.Id", MunicipalitiesId},
                {"Municipalities.Name", MunicipalitiesName},
                {"Municipalities.LocalGovernment", MunicipalitiesLocalGovernment},
                {"Organization.Id", OrganizationId},
                {"Organization.Name", OrganizationName},
                {"Executor", Executor},
                {"Conclusion", Conclusion},
                {"Validity", Validity},
                {"MCNumber", MCNumber},
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