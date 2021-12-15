using System.Collections.Generic;
using System.Linq;

namespace AnimalRegister.MVVM.Model.Mappers.ModelMappers
{
    public static class AnimalCardModelMapper
    {
        public static AnimalCardModel ToModel(AnimalCard animalCard) =>
            new AnimalCardModel
            {
                Id = animalCard.Id,
                Name = animalCard.Name,
                Locality = animalCard.Locality,
                Municipality = animalCard.MunicipalityId.Name,
                Status = animalCard.Status,
                Catch = animalCard.DateOfCatch,
                MK = animalCard.MCNumber
            };

        public static List<AnimalCardModel> ToModel(IEnumerable<AnimalCard> animalCards) =>
            animalCards.Select(ToModel).ToList();
    }
}