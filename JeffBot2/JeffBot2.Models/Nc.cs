using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace JeffBot2.Models
{
    public class Nc
    {
        public int ID { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public int Count { get; set; }
    }
    public class NcDBContext : DbContext
    {
        public DbSet<Nc> Ncs { get; set; }
    }
}