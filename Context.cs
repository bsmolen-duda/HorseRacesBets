using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace HorsesBets
{
    public class Context : DbContext
    {
        public Context() : base()
        {

            Database.SetInitializer(new MigrateDatabaseToLatestVersion<Context, Migrations.Configuration>());

        }

        // Creates Database
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Horse> Horses { get; set; }
        public DbSet<Bet> Bets { get; set; }
        public DbSet<Race> Races { get; set; }


    }
}
