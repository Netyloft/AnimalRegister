// using System;
// using System.Collections.Generic;
// using System.Text;
//
// namespace AnimalRegister.MVVM.Model.Mappers
// {
//     public static class ScheduleCardMapper
//     {
//         public static ScheduleCard GetScheduleCard(Dictionary <string,string> data)
//         {
//             return new ScheduleCard()
//             {
//                 Date = data["date"],
//                 District = data["district"],
//                 Locality = data["locality"],
//                 Status = data["status"],
//                 StatusDate = data["statusDate"]
//             };
//         }
//
//         public static Dictionary<string,string> GetResult(ScheduleCard scheduleCard)
//         {
//             return DataGenerator.GenerateScheduleDataModel(scheduleCard.Date, scheduleCard.District, 
//                 scheduleCard.Locality, scheduleCard.Status, scheduleCard.StatusDate);
//         }
//     }
// }
