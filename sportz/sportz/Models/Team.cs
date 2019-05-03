using System;
using System.Collections.Generic;
using System.Text;

namespace sportz.Models
{
    public class Team
    {
        public string Division { get; set; }
        public string TeamName { get; set; }

        public Team(string division, string name)
        {
            Division = division;
            TeamName = name;
        }
    }
}
