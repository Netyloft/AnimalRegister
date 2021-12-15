using System;

namespace AnimalRegister.MVVM.Model
{
    public class AnimalCardModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long MK { get; set; }
        public DateTime Catch { get; set; }
        public string Municipality { get; set; }
        public string Locality { get; set; }
        public string Status { get; set; }
    }
}