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
        float price;

        public Sponsers()
        {
            Name = "";
            Contract_date = 0;
            Sponser_name = "";
            Sponser_Number = "";
            price = 0;
        }
        public Sponsers(string a,int b,string c,string d)
        {
            Name = a;
            Contract_date = b;
            Sponser_name = c;
            Sponser_Number = d;

        }
        public void setName(string Name)
        {
            this.Name = Name;
        }
        public string GetName()
        {
            return this.Name;

        }

        public void SetContract_date(int Contract_date)
        {
            this.Contract_date = Contract_date;
        }
        public int GetContract_date()
        {
            return this.Contract_date ;
        }
        public void SetSponser_name(string Sponser_name)
        {
            this.Sponser_name = Sponser_name;

        }
        public string GetSponser_name()
        {
          return  this.Sponser_name;
        }
        public void SetSponser_Number(string Sponser_Number)
        {
            this.Sponser_Number = Sponser_Number;
        }
        public string GetSponser_Number(string Sponser_Number)
        {
           return this.Sponser_Number;
        }
        public void Setprice(float price)
        {
            this.price = price;
        }
        public float GetPrice()
        {
            return this.price;
        }

    }
}
