using System;
using System.Collections.Generic;
using AnimalRegister.MVVM.Model.Repositories;

namespace AnimalRegister.MVVM.Model.Controllers
{
    public class AnimalCardService
    {
        private readonly AnimalRepository _animalRepository = new AnimalRepository();
        
        public List<AnimalCard> GetAllAnimalCards()
        {
            LogRepository.AddLog("Получение всех карточек животных", "OK");
            return _animalRepository.GetAll();
        }
        
        public List<AnimalCard> GetAnimalCards(string[] filters, string sort)
        {
            throw new NotImplementedException();
        }

        public AnimalCard OpenAnimalCard(long id)
        {
            LogRepository.AddLog($"Получение крточки животного с id {id}", "OK");
            return _animalRepository.Get(id);
        }

        public void AddAnimalCard(AnimalCard card)
        {
            LogRepository.AddLog($"Добавление карточки животного", "OK");
            _animalRepository.Create(card);
        }

        public void ChangeAnimalCard(AnimalCard card)
        {
            LogRepository.AddLog($"Изменение карточки животного", "OK");
            _animalRepository.Update(card);
        }

        public void RemoveAnimalCard(AnimalCard card)
        {
            LogRepository.AddLog($"Удаление карточки животного с id {card.Id}", "OK");
            _animalRepository.Delete(card);
        }
    }
}