using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BaseballOdds.Models
{
    [Serializable]
    [XmlRoot("away_batting"), XmlType("away_batting")]
    public class Stats
    {
        public int Games { get; set; }
    }
}
