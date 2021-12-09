using System;

namespace AnimalRegister.MVVM.Model
{
    public class ScheduleCard
    {
        public DateTime Date  { get; set; }
        public string District { get; set; }
        public string Locality { get; set; }
        public string Status { get; set; }
        public DateTime StatusDate { get; set; }
    }
}