using System;
using System.Collections.Generic;
using AnimalRegister.MVVM.Model.Mappers.ModelMappers;

namespace AnimalRegister.MVVM.Model.Controllers
{
    public class AnimalCardController
    {
        private readonly AnimalCardService _animalCardService = new AnimalCardService();

        public IEnumerable<AnimalCardModel> GetAllAnimalCards()
        {
            return AnimalCardModelMapper.ToModel(_animalCardService.GetAllAnimalCards());
        }
        
        // public List<Dictionary<string, string>> GetAnimalCards(string[] filters, string sort)
        // {
        //     return _animalCardService.GetAnimalCards(filters, sort);
        // }

        public AnimalCard OpenAnimalCard(long id)
        {
            return _animalCardService.OpenAnimalCard(id);
        }

        public void AddAnimalCard(AnimalCard card)
        {
            _animalCardService.AddAnimalCard(card);
        }

        public void ChangeAnimalCard(AnimalCard card)
        {
            _animalCardService.AddAnimalCard(card);
        }

        public void RemoveAnimalCard(AnimalCard card)
        {
            _animalCardService.RemoveAnimalCard(card);
        }
    }
}