using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace RncManagement.Data
{
    public class Database : DbContext
    {
        public DbSet<Models.RNC> ListadoRNCs { get; set; }
    }
}
