using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFS
{
    public abstract class Person
    {
        string name;
        int dateOfBirth;
        string gender;
        int id;
        bool medicalReport;
        float salary;
        float bonus;
        public Person()
        {
            name = "";
            dateOfBirth = 0;
            gender = "";
            id = 0;
            medicalReport = false;
            salary = 0;
            bonus = 0;
        }
        public Person(string n, int d, string g, int i, bool m, float s, float b)
        {
            name = n;
            dateOfBirth = d;
            gender = g;
            id = i;
            medicalReport = m;
            salary = s;
            bonus = b;

        }
        public void setName(string name)
        {
            this.name = name;

        }
        public string getName()
        {
            return this.name;
        }

        public void setDateOfBirth(int dateOfBirth)
        {

            this.dateOfBirth = dateOfBirth;

        }
        public int getDateOfBirth()
        {
            return this.dateOfBirth;
        }
        public void setGender(string gender)
        {
            this.gender = gender;

        }
        public string getGender()
        {
            return this.gender;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public int getId()
        {
            return this.id;
        }
        public void setMedicalReport(bool medicalReport)
        {

            this.medicalReport = medicalReport;
        }
        public bool getMedicalReport()
        {
            return this.medicalReport;
        }
        public void setSalary(float salary)
        {
            this.salary = salary;
        }
        public float getSalary()
        {
            return this.salary;

        }
        public void setbonus(float bonus)
        {
            this.bonus = bonus;
        }
        public float getBonus()
        {
            return this.bonus;
        }

        public int ageCalculator()
        {

            return 2018 - getDateOfBirth();
        }
        public virtual void displayInfo()
        {

        }

    }
}