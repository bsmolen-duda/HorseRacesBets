namespace HorsesBets.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<HorsesBets.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "HorsesBets.Context";
            AutomaticMigrationDataLossAllowed = true;

        }

        protected override void Seed(HorsesBets.Context context)
        {

            //  Default data.

            context.Horses.AddOrUpdate(h => h.Name,
                new Horse() { Name = "Fast John", YearOfBirth = 2018, NumberOfVictories = 3, Coach = "John Smith", Jockey = "William Stone" },
                new Horse() { Name = "Eddard Stark", YearOfBirth = 2016, NumberOfVictories = 10, Coach = "Barnaba Stealcap", Jockey = "Jessie Burn" },
                new Horse() { Name = "Lucky Luke", YearOfBirth = 2017, NumberOfVictories = 1, Coach = "John Smith", Jockey = "Kevin White" },
                new Horse() { Name = "Pompey", YearOfBirth = 2015, NumberOfVictories = 13, Coach = "Wesley Cooper", Jockey = "Ronald Blackmount" },
                new Horse() { Name = "Asterix", YearOfBirth = 2018, NumberOfVictories = 5, Coach = "Barnaba Stealcap", Jockey = "Donald Quenn" },
                new Horse() { Name = "Nafta", YearOfBirth = 2015, NumberOfVictories = 8, Coach = "Vitaly Krasnavyj", Jockey = "Dimitr Kravchenko" },
                new Horse() { Name = "Neron", YearOfBirth = 2018, NumberOfVictories = 0, Coach = "Scott Westland", Jockey = "John Flower" },
                new Horse() { Name = "Tabun", YearOfBirth = 2018, NumberOfVictories = 1, Coach = "Scott Westland", Jockey = "Ernie Faithfull" },
                new Horse() { Name = "Faith", YearOfBirth = 2018, NumberOfVictories = 2, Coach = "Edward King", Jockey = "Timothy Drower" },
                new Horse() { Name = "Galar", YearOfBirth = 2016, NumberOfVictories = 3, Coach = "John Smith", Jockey = "Ronald Withdraw" });

            List<Customer> customers = new List<Customer>(){ new Customer() { Name = "Antony", Surname = "Wilkins", Balance = 1000M, IDNumber = 65011234456 },
                    new Customer() { Name = "Jeremy", Surname = "Black", Balance = 2000M, IDNumber = 78123109988 },
                    new Customer() { Name = "Robert", Surname = "Wagner", Balance = 1300M, IDNumber = 90020346677 },
                    new Customer() { Name = "Kurt", Surname = "Withdraw", Balance = 200M, IDNumber = 85060489977 } };

            foreach(Customer customer in customers)
            {
                if(!context.Customers.Any(c=>c.IDNumber==customer.IDNumber))
                {
                    context.Customers.Add(customer);
                }
            }

            context.SaveChanges();

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
       
    }
}
