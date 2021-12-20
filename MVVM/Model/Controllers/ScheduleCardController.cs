using System;
using System.Collections.Generic;
using AnimalRegister.MVVM.Model.Mappers;
using AnimalRegister.MVVM.Model.Mappers.ModelMappers;
using AnimalRegister.MVVM.Model.Validators;

namespace AnimalRegister.MVVM.Model.Controllers
{
    public class ScheduleCardController
    {
        private readonly ScheduleService _scheduleService = new ScheduleService();
        public List<Dictionary<string, string>> GetScheduleCards(string[] filters, string sort)
        {
            throw new NotImplementedException();
        }
        
        public List<Dictionary<string, string>> GetAllScheduleCards()
        {
            return ScheduleCardModelMapper.ToModel(_scheduleService.GetAllScheduleCards());
        }

        public Dictionary<string, string> OpenScheduleCard(long id)
        {
            return ScheduleCardMapper.GetResult(_scheduleService.OpenScheduleCard(id));
        }

        public Dictionary<string, string> AddScheduleCard(Dictionary<string, string> data)
        {
            var isValid = ScheduleCardValidator.Validate(data);
            
            if (isValid["validationStatus"].Equals("INVALID"))
                return isValid;

            var card = ScheduleCardMapper.GetScheduleCard(data);
            _scheduleService.AddScheduleCard(card);

            return isValid;
        }
        
        public Dictionary<string, string> ChangeScheduleCard(Dictionary<string, string> data)
        {
            var isValid = ScheduleCardValidator.Validate(data);
            
            if (isValid["validationStatus"].Equals("INVALID"))
                return isValid;

            var card = ScheduleCardMapper.GetScheduleCard(data);
            _scheduleService.ChangeScheduleCard(card);

            return isValid;
        }

        public void RemoveScheduleCard(int id)
        {
            var card = ScheduleCardMapper.GetScheduleCard(id);
            _scheduleService.RemoveScheduleCard(card);
        }
    }
}