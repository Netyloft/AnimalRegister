

using System;

namespace AnimalRegister.MVVM.Model
{
    public class AnimalCard
    {
        public string Name { get; set; }
        public DateTime DateCatch  { get; set; }
        public string Municipality { get; set; }
        public string Locality { get; set; }
        public string Category { get; set; }
        public string Gender { get; set; }
        public string Wool { get; set; }
        public string Size { get; set; }
        public long MK { get; set; }
        public DateTime Conclusion { get; set; }
        public DateTime Validity { get; set; }
        public string Executor { get; set; }
        public string LocalGovernment { get; set; }
        public string Status { get; set; }
        public DateTime StatusDate { get; set; }
    }
    
    
}