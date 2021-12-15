using System;
using System.Collections.Generic;
using AnimalRegister.MVVM.Model.Repositories;

namespace AnimalRegister.MVVM.Model.Controllers
{
    public class AnimalCardService
    {
        private readonly AnimalRepository _animalRepository = new AnimalRepository();
        private readonly LogRepository _logRepository = new LogRepository();
        
        public List<AnimalCard> GetAllAnimalCards()
        {
            return _animalRepository.GetAll();
        }
        
        public List<AnimalCard> GetAnimalCards(string[] filters, string sort)
        {
            throw new NotImplementedException();
        }

        public AnimalCard OpenAnimalCard(long id)
        {
            return _animalRepository.Get(id);
        }

        public void AddAnimalCard(AnimalCard card)
        {
            _animalRepository.CreateOrUpdate(card);
        }

        public void ChangeAnimalCard(AnimalCard card)
        {
            _animalRepository.CreateOrUpdate(card);
        }

        public void RemoveAnimalCard(AnimalCard card)
        {
            _animalRepository.Delete(card);
        }
    }
}