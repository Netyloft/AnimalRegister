using System.Collections.Generic;
using System.Linq;

namespace AnimalRegister.MVVM.Model.Mappers.ModelMappers
{
    public static class ScheduleCardModelMapper
    {
        public static ScheduleCardModel ToModel(ScheduleCard scheduleCard) =>
            new ScheduleCardModel
            {
                Id = scheduleCard.Id,
                Date = scheduleCard.Date,
                Locality = scheduleCard.Locality,
                District = scheduleCard.District,
                Status = scheduleCard.Status
            };

        public static List<ScheduleCardModel> ToModel(IEnumerable<ScheduleCard> scheduleCards)
        {
            var res = new List<ScheduleCardModel>();
            foreach (var scheduleCard in scheduleCards)
            {
                res.Add(ToModel(scheduleCard));
            }

            return res;
            //return scheduleCards.Select(ToModel).ToList();
        }
    }
}