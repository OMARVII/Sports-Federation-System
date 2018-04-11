using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    class Accounting: Employee
    {
        int expenses;
        string Accountant;

        public Accounting()
        {
            expenses = 0;
            Accountant = "";
        }
        public Accounting(int Expenses,string accountant, int n, string x, bool y, string z, string a, string d, string g, string i, bool m, float s, float b) : base(x,y,z,a,d,g,i,m,s,b)
        {
            expenses = Expenses;
            Accountant = accountant;
        }
        public void Setexpenses(int expenses)
        {
            this.expenses = expenses;
        }
        public int Getexpenses()
        {
            return this.expenses;
        }
        public void setAccountant(string Accountant)
        {
            this.Accountant = Accountant;
        }
        public string GetAccountat()
        {
            return this.Accountant;
        }
        public double Bonus_Calc()
        {
           double Salary_with_bonus = 0;
            if (Working_year_calc()>=10)
            {
                Salary_with_bonus = getSalary()+ (getSalary() * 0.2);
            }
            return Salary_with_bonus;

        }
    }
}
