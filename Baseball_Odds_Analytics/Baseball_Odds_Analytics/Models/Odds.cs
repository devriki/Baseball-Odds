using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace Baseball_Odds_Analytics.Models
{
    public class Odds
    {
        public int OddsId { get; set; }
        public string  HomeTeam { get; set;}
        public string AwayTeam { get; set; }
        public DateTime Date { get; set; }
        public double HomeOdds { get; set; }
        public double AwayOdds { get; set; }
    }
}
