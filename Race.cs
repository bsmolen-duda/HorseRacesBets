using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorsesBets
{
    public class Race
    {
        public int RaceID { get; set; }

        public int First { get; set; }
        public int Second { get; set; }
        public int Third { get; set; }
        public int Fourth { get; set; }
        public int Fifth { get; set; }

        
        public bool IsFinished { get; set; }


        public virtual ICollection<Horse> Horses { get; set; }
        public virtual ICollection<Bet> Bets { get; set; }
    }
}
