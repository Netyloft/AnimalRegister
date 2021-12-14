using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnimalRegister.MVVM.Model
{
    public class Journal
    {
        public virtual int Id{ get; set; }
        public virtual DateTime Date{ get; set; }
        public virtual User UserId{ get; set; }
        public virtual string Status{ get; set; }
        public virtual string Operation{ get; set; }
    }
}