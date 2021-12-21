using System.Collections.Generic;

namespace AnimalRegister.MVVM.Model.Mappers
{
    public static class LoginMapper
    {
        //todo Разобраться с UserRights
        public static User GetUser(Dictionary<string,string> data)
        {
            // var municipalities = new Municipalities
            // {
            //     Id = int.Parse(data["Municipalities.Id"]),
            //     Name = data["Municipalities.Name"],
            //     LocalGovernment = data["Municipalities.LocalGoverment"]
            // };
            //
            // var organization = new Organization
            // {
            //     Id = int.Parse(data["Organization.Id"]),
            //     Name = data["Organization.Name"]
            // };

            //var rights = new UserRights
            //{
            //    Id = int.Parse(data["RightsId"]),
            //    Name = data["RigthsName"]
            //}

            return new User()
            {
                // Id = int.Parse(data["Id"]),
                // Name = data["Name"],
                Login = data["Login"],
                Password = data["Password"],
                //RightsId =
                // OrganizationId = organization,
                // MunicipalityId = municipalities
            };
        }      
        
        public static Dictionary<string, string> GetResult(User user)
        {
            return DataGenerator.GenerateLoginDataModel(
                user.Id.ToString(),
                user.Name, 
                user.Login, 
                user.Password,
                RightsName:user.RightsId.Name
               // user.OrganizationId.Id.ToString(),
                //user.OrganizationId.Name
                //user.OrganizationId.Address разве мы храним адрес?
                //user.MunicipalityId.Id.ToString(),
               // user.MunicipalityId.Name,
                //user.MunicipalityId.LocalGovernment
                );
        }
    }
}