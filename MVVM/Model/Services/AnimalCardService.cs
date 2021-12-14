using System;
using System.Collections.Generic;
using AnimalRegister.MVVM.Model.Repositories;

namespace AnimalRegister.MVVM.Model.Controllers
{
    public class AnimalCardService
    {
        private readonly AnimalRepository _animalRepository = new AnimalRepository();
        public List<Dictionary<string, string>> GeAnimalCards(string[] filters, string sort)
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, string> OpenAnimalCard(long id)
        {
            throw new NotImplementedException();
        }

        public void AddAnimalCard(AnimalCard card)
        {
            _animalRepository.CreateOrUpdate(card);
        }

        public void ChangeAnimalCard(Dictionary<string, string> card)
        {
            throw new NotImplementedException();
        }

        public void RemoveAnimalCard(long id)
        {
            throw new NotImplementedException();
        }
    }
}