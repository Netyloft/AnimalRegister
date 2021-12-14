using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnimalRegister.MVVM.Model.Tables
{
    class Journal
    {
        public int Id;
        public DateTime Date;
        public int UserId;
        public string Status;
        public string Operation;
    }
}