﻿using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AnimalRegister.MVVM.Model.Tables
{
    class Users
    {
        public int Id;
        public string Name;
        public string Login;
        public string Password;
        public int RoleId;
        public int OrganizationId;
        public int LocalGovermentId;
    }
}