﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WhoLivesApp.Models;

namespace WhoLivesApp.Models
{
    public class Report3Context : DbContext
    {
        public Report3Context() : base("BancoApartamentos")
        {

        }
        public DbSet<Report3> Report3List { get; set; }
    }
}