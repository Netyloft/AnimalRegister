using AnimalRegister.MVVM.Model.Repositories;
using System;
using System.Collections.Generic;

namespace AnimalRegister.MVVM.Model.Controllers
{
    public class ScheduleService
    {
        private readonly ScheduleRepository _scheduleRepository = new ScheduleRepository();

        public List<ScheduleCard> GetScheduleCards(string[] filters, string sort)
        {
            throw new NotImplementedException();
        }
        
        public List<ScheduleCard> GetAllScheduleCards()
        {
            LogRepository.AddLog("Получение всех карточек отлова", "OK");
            return _scheduleRepository.GetAll();
        }

        public ScheduleCard OpenScheduleCard(long id)
        {
            LogRepository.AddLog($"Получение крточки отолва с id {id}", "OK");
            return _scheduleRepository.Get(id);
        }

        public void AddScheduleCard(ScheduleCard card)
        {
            LogRepository.AddLog($"Добавление карточки отлова", "OK");
            _scheduleRepository.Create(card);
        }

        public void ChangeScheduleCard(ScheduleCard scheduleCard)
        {
            LogRepository.AddLog($"Изменение карточки отлова", "OK");
            _scheduleRepository.Update(scheduleCard);
        }

        public void RemoveScheduleCard(ScheduleCard card)
        {
            LogRepository.AddLog($"Удаление карточки отлова с id {card.Id}", "OK");
            _scheduleRepository.Delete(card);
        }
    }
}