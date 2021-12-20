using System;

namespace AnimalRegister.MVVM.Model
{
    public class ScheduleCardModel
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string District { get; set; }
        public string Locality { get; set; }
        public string Status { get; set; }
    }
}