using System;
using System.Collections.Generic;
using AnimalRegister.MVVM.Model.Mappers.ModelMappers;

namespace AnimalRegister.MVVM.Model.Controllers
{
    public class ScheduleCardController
    {
        private readonly ScheduleService _scheduleService = new ScheduleService();
        public List<Dictionary<string, string>> GetScheduleCards(string[] filters, string sort)
        {
            throw new NotImplementedException();
        }
        
        public List<ScheduleCardModel> GetAllScheduleCards()
        {
            return ScheduleCardModelMapper.ToModel(_scheduleService.GetAllScheduleCards());
        }

        public ScheduleCard OpenScheduleCard(long id)
        {
            return _scheduleService.OpenScheduleCard(id);
        }

        public void AddScheduleCard(ScheduleCard card)
        {
            _scheduleService.AddScheduleCard(card);
        }

        public void RemoveScheduleCard(ScheduleCard card)
        {
            _scheduleService.RemoveScheduleCard(card);
        }
    }
}