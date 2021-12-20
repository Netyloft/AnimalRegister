using System;
using System.Collections.Generic;
using AnimalRegister.MVVM.Model.Mappers;
using AnimalRegister.MVVM.Model.Mappers.ModelMappers;
using AnimalRegister.MVVM.Model.Validators;

namespace AnimalRegister.MVVM.Model.Controllers
{
    public class AnimalCardController
    {
        private readonly AnimalCardService _animalCardService = new AnimalCardService();

        public IEnumerable<Dictionary<string, string>> GetAllAnimalCards()
        {
            return AnimalCardModelMapper.ToModel(_animalCardService.GetAllAnimalCards());
        }

        // public List<Dictionary<string, string>> GetAnimalCards(string[] filters, string sort)
        // {
        //     return _animalCardService.GetAnimalCards(filters, sort);
        // }

        public Dictionary<string, string> OpenAnimalCard(long id)
        {
            return AnimalCardMapper.GetResult(_animalCardService.OpenAnimalCard(id));
        }

        public Dictionary<string, string> AddAnimalCard(Dictionary<string, string> data)
        {
            var isValid = AnimalCardValidator.Validate(data);

            if (isValid["validationStatus"].Equals("INVALID"))
                return isValid;
            
            var card = AnimalCardMapper.GetAnimalCard(data);

            _animalCardService.AddAnimalCard(card);

            return isValid;
        }
        
        public Dictionary<string, string> ChangeAnimalCard(Dictionary<string, string> data)
        {
            var isValid = AnimalCardValidator.Validate(data);

            if (isValid["validationStatus"].Equals("INVALID"))
                return isValid;
            
            var card = AnimalCardMapper.GetAnimalCard(data);

            _animalCardService.ChangeAnimalCard(card);

            return isValid;
        }

        public void RemoveAnimalCard(int id)
        {
            var card = AnimalCardMapper.GetAnimalCard(id);
            _animalCardService.RemoveAnimalCard(card);
        }
    }
}