using System;

namespace AnimalRegister.MVVM.Model
{
    public class ScheduleCardModel
    {
        public long Id { get; set; }
        public DateTime Date { get; set; }
        public string District { get; set; }
        public string Locality { get; set; }
        public string Status { get; set; }
    }
}