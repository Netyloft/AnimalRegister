using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnimalRegister.MVVM.Model
{
    public class ScheduleCard
    {
        public virtual int Id{ get; set; }
        public virtual DateTime Date{ get; set; }
        public virtual string District{ get; set; }
        public virtual string Locality{ get; set; }
        public virtual string Status{ get; set; }
        public virtual DateTime StatusDate{ get; set; }
        public virtual Organization OrganizationId{ get; set; }
        public virtual Municipalities MunicipalitiesId{ get; set; }
    }
}