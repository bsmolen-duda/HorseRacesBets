using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsesBets
{
    public class Horse
    {
        public int HorseID { get; set; }
        public string Name { get; set; }
        public int YearOfBirth{ get; set; }
        public int NumberOfVictories { get; set; }
        public string Coach { get; set; }
        public string Jockey { get; set; }

        public virtual ICollection<Race> Races { get; set; }
        public virtual ICollection<Bet> Bets { get; set; }
    }
}
