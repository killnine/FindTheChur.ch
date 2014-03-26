using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web.DataAccess
{
    public class ChurchContext : DbContext
    {
        public ChurchContext() : base("FindTheChurchConnection")
        {

        }

        public DbSet<Church> Churches { get; set; }
        public DbSet<ServiceTime> ServiceTimes { get; set; }
    }
}