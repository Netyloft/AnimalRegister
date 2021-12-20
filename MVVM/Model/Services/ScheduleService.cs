using AnimalRegister.MVVM.Model.Repositories;
using System;
using System.Collections.Generic;

namespace AnimalRegister.MVVM.Model.Controllers
{
    public class ScheduleService
    {
        private readonly ScheduleRepository _scheduleRepository = new ScheduleRepository();
        private readonly LogRepository _logRepository = new LogRepository();

        public List<ScheduleCard> GetScheduleCards(string[] filters, string sort)
        {
            throw new NotImplementedException();
        }
        
        public List<ScheduleCard> GetAllScheduleCards()
        {
            return _scheduleRepository.GetAll();
        }

        public ScheduleCard OpenScheduleCard(long id)
        {
            return _scheduleRepository.Get(id);
        }

        public void AddScheduleCard(ScheduleCard card)
        {
            _scheduleRepository.Create(card);
        }

        public void ChangeScheduleCard(ScheduleCard scheduleCard)
        {
            _scheduleRepository.Update(scheduleCard);
        }

        public void RemoveScheduleCard(ScheduleCard card)
        {
            _scheduleRepository.Delete(card);
        }
    }
}