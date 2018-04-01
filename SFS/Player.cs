using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Player : Person
    {
        string TeamName;
        // list of championships
        bool senior;
        Player()
        {
            TeamName = "";
            if (ageCalculator() > 18)
            {
                senior = true;
            }
            else
            {
                senior = false;
            }
        }

        Player(string name, string a, int d, string g, int i, bool m, float s, float b) : base(a, d, g, i, m, s, b)
        {
            this.TeamName = name;

        }

        public void set_teamname(string name)
        {
            TeamName = name;
        }
        public bool is_senior()
        {
            return this.senior;
        }
        public void display()
        {

        }
        public void displayplayer()
        {

        }

    }
}
