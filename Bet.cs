using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace HorsesBets
{
    public class Bet
    {
        public int BetID { get; set; }
        public float Value { get; set; }
        public float ExchangeRate { get; set; }
        public string KindOfBet { get; set; }
        public bool IsChecked { get; set; }


        public Horse First { get; set; }
        public Horse Second { get; set; }
        public Horse Third { get; set; }
        
        public Race Race { get; set; }
        public Customer Customer { get; set; }

      
        
    }
}


