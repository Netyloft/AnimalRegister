using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnimalRegister.MVVM.Model
{
    public class AnimalCard
    {
        public virtual int Id { get; set; }
        public virtual string Status { get; set; }
        public virtual string Category{ get; set; }
        public virtual string Name{ get; set; }
        public virtual string Size{ get; set; }
        public virtual string TypeOfWool{ get; set; }
        public virtual string Gender{ get; set; }
        public virtual DateTime DateOfCatch{ get; set; }
        public virtual string Locality{ get; set; }
        public virtual DateTime StatusDate{ get; set; }
        public virtual Municipalities MunicipalityId{ get; set; }
        public virtual Organization OrganizationId{ get; set; }
        public virtual string Executor{ get; set; }
        public virtual DateTime Conclusion{ get; set; }
        public virtual DateTime Validity{ get; set; }
    }
}