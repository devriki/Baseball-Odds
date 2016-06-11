﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BaseballOdds.Models
{
    public class Teams
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Games { get; set; }
        public double Wins { get; set; }
        public double Losses { get; set; }
        public double RunsScored { get; set; }
        public double RunsAgainst { get; set; }
        public int TeamId { get; set; }

    }


}