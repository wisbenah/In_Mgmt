using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace In_Mgmt.Models
{
    public class In_MgmtContext : DbContext
    {
        public DbSet<Container> Containers { get; set; }
        public DbSet<UOM> UOMs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<UOM_Type> UOM_Types { get; set; }
    }
}