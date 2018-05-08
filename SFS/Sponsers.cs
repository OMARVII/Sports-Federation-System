using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Sponsers
    {
      
        string Sponser_name;
        
        int Sponsor_price;

        public Sponsers()
        {
            Sponser_name = "";
            Sponsor_price = 10000;
        }
        public Sponsers(string c, int e)
        {
            Sponser_name = c;
            Sponsor_price = e;

        }
       
        public string GetSponser_name()
        {
          return  this.Sponser_name;
        }
        public int GetSponsor_price()
        {
            return this.Sponsor_price;
        }

    }
}
