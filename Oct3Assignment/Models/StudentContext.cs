﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Oct3Assignment.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("MyConnection") { }

        public DbSet<MEmployee> MEmployees { get; set; }

    }
}