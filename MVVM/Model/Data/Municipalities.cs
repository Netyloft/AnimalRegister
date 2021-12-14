
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnimalRegister.MVVM.Model
{
    public class Municipalities
    {
        public virtual int Id{ get; set; }
        public virtual string Name{ get; set; }
        public virtual string LocalGovernment{ get; set; }
    }
}