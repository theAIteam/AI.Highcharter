using System.Collections.Generic;

namespace AI.HighCharter.Web.Models
{
    public class HighchartsSeries
    {
        public string name { get; set; }
        public List<decimal> data { get; set; } 
    }
}