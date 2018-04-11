using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Coach : Employee
    {
        string team;
       public List<Championships> champlist;
        public Coach()
        {
            team = "";
          champlist = new List<Championships>();
        }
        public Coach(string team, int n, string x, bool y, string z, string a, string d, string g, string i, bool m, float s, float b) : base(x, y, z, a, d, g, i, m, s, b)
        {
            this.team = team;
        }
        public void setTeam(string team)
        {
            this.team = team;
        }
        public string getTeam()
        {
            return this.team;
        }
    }
}
