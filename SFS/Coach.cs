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
        List<Championships> champlist;
        public Coach()
        {
            team = "";
            champlist = new List<Championships>();
        }
        public Coach(string team, int n, int x, bool y, string z, string a, int d, string g, int i, bool m, float s, float b) : base(n, x, y, z, a, d, g, i, m, s, b)
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
