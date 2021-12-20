using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalRegister.MVVM.Model.Mappers
{
    public static class AnimalCardMapper
    {
        public static AnimalCard GetAnimalCard(Dictionary<string, string> data)
        {
            var municipalities = new Municipalities
            {
                Id = int.Parse(data["Municipality.Id"]),
                Name = data["Municipalities.Name"],
                LocalGovernment = data["Municipalities.LocalGovernment"]
            };

            var organization = new Organization
            {
                Id = int.Parse(data["Organization.Id"]),
                Name = data["Organization.Name"]
            };

            return new AnimalCard()
            {
                Id = int.Parse(data["Id"]),
                Name = data["Name"],
                DateOfCatch = DateTime.Parse(data["DateOfCatch"]),
                MunicipalityId = municipalities,
                Locality = data["Locality"],
                Category = data["Category"],
                Gender = data["Gender"],
                TypeOfWool = data["TypeOfWool"],
                Size = data["Size"],
                MCNumber = data["MCNumber"],
                Conclusion = DateTime.Parse(data["Conclusion"]),
                Validity = DateTime.Parse(data["Validity"]),
                StatusDate = DateTime.Parse(data["StatusDate"]),
                Executor = data["Executor"],
                Status = data["Status"],
                OrganizationId = organization
            };
        }

        public static AnimalCard GetAnimalCard(int id)
        {
            return new AnimalCard() {Id = id};
        }

        public static Dictionary<string, string> GetResult(AnimalCard animalCard)
        {
            return DataGenerator.GenerateAnimalDataModel(
                animalCard.Id.ToString(),
                animalCard.Status,
                animalCard.Category,
                animalCard.Name,
                animalCard.Size,
                animalCard.TypeOfWool,
                animalCard.Gender,
                animalCard.DateOfCatch.ToString(),
                animalCard.Locality,
                animalCard.StatusDate.ToString(),
                animalCard.MunicipalityId.Id.ToString(),
                animalCard.MunicipalityId.Name,
                animalCard.MunicipalityId.LocalGovernment,
                animalCard.OrganizationId.Id.ToString(),
                animalCard.OrganizationId.Name,
                animalCard.Executor,
                animalCard.Conclusion.ToString(),
                animalCard.Validity.ToString(),
                animalCard.MCNumber);
        }
    }
}