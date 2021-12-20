using System;

namespace AnimalRegister.MVVM.Model
{
    public class AnimalCardModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MK { get; set; }
        public DateTime Catch { get; set; }
        public string Municipality { get; set; }
        public string Locality { get; set; }
        public string Status { get; set; }
    }
}