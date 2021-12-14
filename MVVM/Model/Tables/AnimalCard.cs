using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnimalRegister.MVVM.Model.Tables
{
    class AnimalCard
    {
        public int Id;
        public string Status;
        public string Category;
        public string Name;
        public string Size;
        public string TypeOfWool;
        public string Gender;
        public DateTime DateOfCatch;
        public string Locality;
        public DateTime StatusDate;
        public int MunicipalityId;
        public int OrganizationId;
        public string Executor;
        public DateTime Conclusion;
        public DateTime Validity;
    }
}