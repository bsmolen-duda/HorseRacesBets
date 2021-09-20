using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.Entity;

namespace HorsesBets
{

    // This class manages operation on database.
    public class DatabaseManager
    {
        public DatabaseManager()
        {

        }


        //This method adds a new horse in Horses table in database.

        public void AddHorse(string name, string year, string victories, string coach, string jockey)
        {

            //Basic checking correctness of data.

            if (!(String.IsNullOrEmpty(name) || Int32.TryParse(year, out int yearInt) == false
                || Int32.TryParse(victories, out int victoriesInt) == false || String.IsNullOrEmpty(coach)
                || String.IsNullOrEmpty(jockey)))
            {
                //Adding a new horse to the table "Horses" in the databse.

                using (Context db = new Context())
                {
                    Horse horse = new Horse()
                    {
                        Name = name,
                        YearOfBirth = yearInt,
                        NumberOfVictories = victoriesInt,
                        Coach = coach,
                        Jockey = jockey
                    };

                    db.Horses.Add(horse);
                    db.SaveChanges();
                }
                System.Windows.Forms.MessageBox.Show("Horse added succesfully.");
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Missing or incorrect data.");
            }
        }



        //This method adds a new Customer to the table Customers in database.

        public void AddCustomer(string id, string name, string surname, string balance)
        {

            // Basic checking correctness of data. 

            if (!(long.TryParse(id, out long ID) == false || String.IsNullOrEmpty(name) || String.IsNullOrEmpty(surname) || decimal.TryParse(balance, out decimal balanceInt) == false))
            {
                //Adding a new customer to the table "Customers" in database.

                using (Context db = new Context())
                {

                    Customer customer = new Customer()
                    {
                        IDNumber = ID,
                        Name = name,
                        Surname = surname,
                        Balance = balanceInt
                    };

                    db.Customers.Add(customer);
                    db.SaveChanges();


                    System.Windows.Forms.MessageBox.Show("Customer added succesfully.");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Missing or incorrect data.");
            }
        }




        // Generates a random race.

        public void GenerateRace()
        {
            using (Context db = new Context())
            {
                int number = db.Horses.Count();
                var rnd = new Random();
                List<int> result = new List<int>();

                // Randomly choose 5 horses for the race and randomly set the result.
                int counter = 0;
                while (counter < 5)
                {
                    int randomNumber = rnd.Next(1, number);
                    if (!result.Contains(randomNumber))
                    {
                        result.Add(randomNumber);
                        counter++;
                    }
                }

                // Creates a new record in the table "Races" in database.
                Race race = new Race() { First = result[0], Second = result[1], Third = result[2], Fourth = result[3], Fifth = result[4] };

                foreach (int i in result)
                {
                    Horse horse = db.Horses.First(h => h.HorseID == i);

                    // We have to create a list because default value is null.
                    if (race.Horses == null)
                    {
                        race.Horses = new List<Horse>();
                    }
                    race.Horses.Add(horse);
                }

                db.Races.Add(race);

                db.SaveChanges();

                System.Windows.Forms.MessageBox.Show("Race added.");

            }
        }




        //This method creates a new bet.

        public void AddBet(string customerID, string value, string rate, string kind, string raceID, string horse1, string horse2, string horse3)
        {
            bool horses = true;
            switch(kind)
            {
                case "Zwyczajny":
                    horses = String.IsNullOrEmpty(horse1);
                    break;

                case "Dwójka":
                    horses = String.IsNullOrEmpty(horse1) || String.IsNullOrEmpty(horse2);
                    break;

                case "Trójka":
                    horses = String.IsNullOrEmpty(horse1) || String.IsNullOrEmpty(horse2) || String.IsNullOrEmpty(horse3);
                    break;
            }

            // Basic checking correctness of data.
            using (Context db = new Context())
            {
                if (!(long.TryParse(customerID, out long id) == false || int.TryParse(raceID, out int rid) == false || float.TryParse(value, out float valueInt) == false
                    || float.TryParse(rate, out float exRate) == false || horses))
                {
                    // Checks if the customer already exists in "Customers" table.

                    if (db.Customers.Any(c => c.IDNumber == id))
                    {
                        Customer customer = db.Customers.Where(c => c.IDNumber == id).First();

                        // Checks if the race already exists in "Races" table.

                        if (db.Races.Any(r => r.RaceID == rid) && (db.Races.Where(r => r.RaceID == rid).First().IsFinished==false))
                        {
                            Race race = db.Races.Where(r => r.RaceID == rid).First();
                            Horse horse1st = new Horse();
                            Horse horse2nd = null;
                            Horse horse3rd = null;

                            switch(kind)
                            {
                                case "Zwyczajny":
                                    horse1st=Zwyczajny(horse1, rid, db);
                                    break;

                                case "Dwójka":
                                    (horse1st,horse2nd) = Dwojka(horse1, horse2, rid, db);
                                    break;

                                case "Trojka":
                                    (horse1st, horse2nd,horse3rd) = Trojka(horse1, horse2,horse3, rid, db);
                                    break;
                            }

                            // Creates a bet.
                            Bet bet = new Bet() { Value = valueInt, ExchangeRate = exRate, KindOfBet = kind, Race = race, First = horse1st, Second = horse2nd, Third = horse3rd, Customer = customer };
                            db.Bets.Add(bet);
                            customer.Balance -= (decimal)valueInt;

                            db.SaveChanges();
                            System.Windows.Forms.MessageBox.Show("Bet added succesfully.");

                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("There is no race with the given ID or the race is finished.");
                        }

                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("First add a new customer.");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Incorrect data format.");
                }
            }
        }



        //The following three ,ethods are auxilary method for adding a bet.

        private (Horse,Horse,Horse) Trojka(string horse1, string horse2, string horse3, int rid,Context db)
        {
            // Checks if the horses already exist in "Horses" table.

            if (db.Horses.Any(h => h.Name == horse1) && db.Horses.Any(h => h.Name == horse2) && db.Horses.Any(h => h.Name == horse3))
            {
                Horse horse1st = db.Horses.Where(h => h.Name == horse1).First();
                Horse horse2nd = db.Horses.Where(h => h.Name == horse2).First();
                Horse horse3rd = db.Horses.Where(h => h.Name == horse3).First();

                // Checks if the horses run in the given race.

                if (db.Races.Any(r => (r.RaceID == rid && r.Horses.Any(h => h.Name == horse1) && r.Horses.Any(h => h.Name == horse2) && r.Horses.Any(h => h.Name == horse3))))
                {
                    return (horse1st, horse2nd, horse3rd);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("There is no race with given horses participated.");
                    return (null, null, null);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("There is no such horses in database.");
                return (null, null, null);
            }
        }




        private (Horse, Horse) Dwojka(string horse1, string horse2, int rid, Context db)
        {
            // Checks if the horses already exist in "Horses" table.

            if (db.Horses.Any(h => h.Name == horse1) && db.Horses.Any(h => h.Name == horse2))
            {
                Horse horse1st = db.Horses.Where(h => h.Name == horse1).First();
                Horse horse2nd = db.Horses.Where(h => h.Name == horse2).First();

                // Checks if the horses run in the given race.

                if (db.Races.Any(r => (r.RaceID == rid && r.Horses.Any(h => h.Name == horse1) && r.Horses.Any(h => h.Name == horse2))))
                {
                    return (horse1st, horse2nd);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("There is no race with given horses participated.");
                    return (null, null);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("There is no such horses in database.");
                return (null, null);
            }
        }




        private Horse Zwyczajny(string horse1, int rid, Context db)
        {
            // Checks if the horses already exist in "Horses" table.

            if (db.Horses.Any(h => h.Name == horse1) )
            {
                Horse horse1st = db.Horses.Where(h => h.Name == horse1).First();

                // Checks if the horses run in the given race.

                if (db.Races.Any(r => (r.RaceID == rid && r.Horses.Any(h => h.Name == horse1))))
                {
                    return (horse1st);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("There is no race with given horses participated.");
                    return (null);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("There is no such horses in database.");
                return (null);
            }
        }




        
        // This method cheks all bets for th egiven race.

        public void Check(string raceID)
        {
            if (int.TryParse(raceID, out int id))
            {
                using (Context db = new Context())
                {
                    // Cheks if a race with the given id exists.

                    if (db.Races.Any(r => r.RaceID == id))
                    {
                        Race race = db.Races.Where(r => r.RaceID == id).First();

                        
                        if (race.IsFinished == true)
                        {
                            // Selecting all bets for the given race. Loads also connected entities.
                            List<Bet> bets = db.Bets.Where(b => b.Race.RaceID == id ).Include("Customer").Include("First").Include("Second").Include("Third").ToList<Bet>();
                            foreach (Bet bet in bets)
                            {
                                if (bet.IsChecked == false)
                                {
                                    // This checks if the bet wins.
                                    bool expression = false;
                                    switch (bet.KindOfBet)
                                    {
                                        case "Zwyczajny":
                                            expression = bet.First.HorseID == race.First;
                                            break;

                                        case "Dwójka":
                                            expression = bet.First.HorseID == race.First && bet.Second.HorseID == race.Second;
                                            break;

                                        case "Trójka":
                                            expression = bet.First.HorseID == race.First && bet.Second.HorseID == race.Second && bet.Third.HorseID == race.Third;
                                            break;
                                    }


                                    if (expression == true)
                                    {
                                        // Choosing customer who bought the bet and paying the reward.
                                        Customer customer = db.Customers.Where(c => c.CustomerID == bet.Customer.CustomerID).First();

                                        float value = bet.Value * bet.ExchangeRate;
                                        customer.Balance += (decimal)value;

                                    }

                                    bet.IsChecked = true;

                                    db.SaveChanges();
                                }
                            }

                            System.Windows.Forms.MessageBox.Show("Bets checked.");
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("The race is not finished yet.");
                        }

                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("There is no race with given ID.");
                    }
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect ID, it has to be an integer.");
            }
        }


        // Change the status of the race to finished.

        public void FinishRace(string raceID)
        {
            if (int.TryParse(raceID, out int id))
            {
                using (Context db = new Context())
                {
                    // Cheks if a race with the given id exists.

                    if (db.Races.Any(r => r.RaceID == id))
                    {
                        // Sleecting the race with given ID.
                        Race race = db.Races.Where(r => r.RaceID == id).First();

                        // Finishes the race.
                        if (race.IsFinished == false)
                        {
                            race.IsFinished = true;
                            db.SaveChanges();

                            System.Windows.Forms.MessageBox.Show("Race finished.");
                        }
                        else
                        {
                            System.Windows.Forms.MessageBox.Show("Race is finished already.");
                        }
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("There is no race with given ID.");
                    }

                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Incorrect ID, it has to be an integer.");
            }
        }
    }
}
