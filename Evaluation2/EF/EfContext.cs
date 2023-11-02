using Evaluation2.METIER;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation2.EF
{
    public class EfContext : DbContext
    {
        public DbSet<Compte> Comptes { get; set; }
        public EfContext() : base("connString") { }
    }
}
