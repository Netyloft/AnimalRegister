using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnimalRegister.MVVM.Model.Tables
{
    class ScheduleCard
    {
        public int Id;
        public DateTime Date;
        public string District;
        public string Locality;
        public string Status;
        public DateTime StatusDate;
        public int OrganizationId;
        public int LocalGovermentId;
    }
}