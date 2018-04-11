using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Sponsers
    {
        string Name;
        int Contract_date;
        string Sponser_name;
        string Sponser_Number;
        int Sponsor_price;

        public Sponsers()
        {
            Name = "";
            Contract_date = 0;
            Sponser_name = "";
            Sponser_Number = "";
            Sponsor_price = 10000;
        }
        public Sponsers(string a,int b,string c,string d, int e)
        {
            Name = a;
            Contract_date = b;
            Sponser_name = c;
            Sponser_Number = d;
            Sponsor_price = e;

        }
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return this.Name;

        }

       
        public int GetContract_date()
        {
            return this.Contract_date ;
        }
      
        public string GetSponser_name()
        {
          return  this.Sponser_name;
        }
      
        public string GetSponser_Number(string Sponser_Number)
        {
           return this.Sponser_Number;
        }
        public int GetSponsor_price()
        {
            return this.Sponsor_price;
        }

    }
}
