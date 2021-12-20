using System.Collections.Generic;
using System.Linq;

namespace AnimalRegister.MVVM.Model.Mappers.ModelMappers
{
    public static class ScheduleCardModelMapper
    {
        public static Dictionary<string, string> ToModel(ScheduleCard scheduleCard) =>
            DataGenerator.GenerateScheduleModel(scheduleCard.Id.ToString(), scheduleCard.Date.ToString(),
                scheduleCard.District, scheduleCard.Locality, scheduleCard.Status);


        public static List<Dictionary<string, string>> ToModel(IEnumerable<ScheduleCard> scheduleCards)
        {
            var res = new List<Dictionary<string, string>>();
            foreach (var scheduleCard in scheduleCards)
            {
                res.Add(ToModel(scheduleCard));
            }

            return res;
            
        }
    }
}