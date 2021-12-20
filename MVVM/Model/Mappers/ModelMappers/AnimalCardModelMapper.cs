using System.Collections.Generic;
using System.Linq;

namespace AnimalRegister.MVVM.Model.Mappers.ModelMappers
{
    public static class AnimalCardModelMapper
    {
        public static Dictionary<string, string> ToModel(AnimalCard animalCard) => DataGenerator.GenerateAnimalModel(
            animalCard.Id.ToString(), animalCard.Name, animalCard.MCNumber, animalCard.MunicipalityId.Name,
            animalCard.Locality, animalCard.Status, animalCard.DateOfCatch.ToString());
            

        public static List<Dictionary<string, string>> ToModel(IEnumerable<AnimalCard> animalCards) =>
            animalCards.Select(ToModel).ToList();
    }
}