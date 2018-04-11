using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Data;
namespace SFS
{
    class Containers
    {
        public static List<Player> Player_list = new List<Player>();
        public static List<Club> Club_list = new List<Club>();
        public static List<Employee> Employee_list = new List<Employee>();
        public static List<Sponsers> Sponsor_list = new List<Sponsers>();
        public static List<Team> Team_list = new List<Team>();
        public static List<Championships> championship_list = new List<Championships>();


        public static void Read_Players()
        {
            Containers.Player_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Players.xml");
            XmlNodeList list = doc.GetElementsByTagName("Player");
            BinaryFormatter f = new BinaryFormatter();
            FileStream w = new FileStream("Players.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string Name = list_2[0].Name;
                string nvalue = list_2[0].InnerText;
                string ID = list_2[1].Name;
                string ivalue = list_2[1].InnerText;
                string mobile_number = list_2[2].Name;
                string mvalue = list_2[2].InnerText;
                string gender = list_2[3].Name;
                string gval = list_2[3].InnerText;
                string medical_form = list_2[4].Name;
                string medvalue = list_2[4].InnerText;
                string salary = list_2[5].Name;
                string sval = list_2[5].InnerText;
                string bonus = list_2[6].Name;
                string bval = list_2[6].InnerText;
                string date_of_birth = list_2[7].Name;
                string dval = list_2[7].InnerText;
                string team_name = list_2[8].Name;
                string tval = list_2[8].InnerText;
                Player p = new Player(tval, nvalue, dval, gval, ivalue,bool.Parse(medvalue), float.Parse(sval), float.Parse(bval));
                Player_list.Add(p);
            }
            w.Close();
        }
        public static void Read_Employees()
        {
            Containers.Employee_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Employees.xml");
            XmlNodeList list = doc.GetElementsByTagName("Employee");
            BinaryFormatter f = new BinaryFormatter();
            FileStream w = new FileStream("Employees.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string Name = list_2[0].Name;
                string nvalue = list_2[0].InnerText;
                string ID = list_2[1].Name;
                string ivalue = list_2[1].InnerText;
                string mobile_number = list_2[1].Name;
                string mvalue = list_2[1].InnerText;
                string gender = list_2[2].Name;
                string gval = list_2[2].InnerText;
                string medical_form = list_2[3].Name;
                string medvalue = list_2[3].InnerText;
                string salary = list_2[4].Name;
                string sval = list_2[4].InnerText;
                string bonus = list_2[5].Name;
                string bval = list_2[5].InnerText;
                string Employment_date = list_2[6].Name;
                string edval = list_2[6].InnerText;
                string Working_year = list_2[7].Name;
                string wval = list_2[7].InnerText;
                string date_of_birth = list_2[8].Name;
                string dval = list_2[8].InnerText;
                string available = list_2[9].Name;
                string aval = list_2[8].InnerText;
                string department = list_2[10].Name;
                string depval = list_2[10].InnerText;
                Employee p = new Employee(edval, bool.Parse(aval), depval, nvalue, dval, gval, ivalue, bool.Parse(medvalue), float.Parse(sval), float.Parse(bval));
                Employee_list.Add(p);
            }
            w.Close();
        }
    
    public static void Read_Clubs()
    {
        Containers.Club_list.Clear();
        XmlDocument doc = new XmlDocument();
        doc.Load("Clubs.xml");
        XmlNodeList list = doc.GetElementsByTagName("Club");
        BinaryFormatter f = new BinaryFormatter();
        FileStream w = new FileStream("Clubs.xml", FileMode.Open);
        for (int i = 0; i < list.Count; i++)
        {
            XmlNodeList list_2 = list[i].ChildNodes;
            string Name = list_2[0].Name;
            string nvalue = list_2[0].InnerText;
            string starting_date = list_2[1].Name;
            string sdvalue = list_2[1].InnerText;
            string Club_teams = list_2[1].Name;
            string ctvalue = list_2[1].InnerText;
            string club_championships = list_2[2].Name;
            string ccval = list_2[2].InnerText;
            string Club_sponsors = list_2[3].Name;
            string csvalue = list_2[3].InnerText;
                Club c = new Club(nvalue, sdvalue);
                Club_list.Add(c);
        }
        w.Close();
    }
        public static void Read_Championships()
        {
            Containers.championship_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Championships.xml");
            XmlNodeList list = doc.GetElementsByTagName("Championship");
            BinaryFormatter f = new BinaryFormatter();
            FileStream w = new FileStream("Championships.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string type = list_2[0].Name;
                string tvalue = list_2[0].InnerText;
                string place = list_2[1].Name;
                string pvalue = list_2[1].InnerText;
                string senior = list_2[1].Name;
                string svalue = list_2[1].InnerText;
                string numberofresults = list_2[2].Name;
                string nvval = list_2[2].InnerText;
                Championships c = new Championships(tvalue, pvalue,bool.Parse( svalue));
                championship_list.Add(c);
            }
            w.Close();
        }
        public static void Read_Teams()
        {
            Containers.championship_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Teams.xml");
            XmlNodeList list = doc.GetElementsByTagName("Team");
            BinaryFormatter f = new BinaryFormatter();
            FileStream w = new FileStream("Teams.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string Name = list_2[0].Name;
                string nvalue = list_2[0].InnerText;
                string senior = list_2[1].Name;
                string svalue = list_2[1].InnerText;
                string numberofresults = list_2[1].Name;
                string nrvalue = list_2[1].InnerText;
               
                Team t = new Team(nvalue,bool.Parse(svalue));
                Team_list.Add(t);
            }
            w.Close();
        }
      /* public void Read_Sponsors()
        {
            Containers.championship_list.Clear();
            XmlDocument doc = new XmlDocument();
            doc.Load("Championships.xml");
            XmlNodeList list = doc.GetElementsByTagName("Championship");
            BinaryFormatter f = new BinaryFormatter();
            FileStream w = new FileStream("Championships.xml", FileMode.Open);
            for (int i = 0; i < list.Count; i++)
            {
                XmlNodeList list_2 = list[i].ChildNodes;
                string type = list_2[0].Name;
                string tvalue = list_2[0].InnerText;
                string place = list_2[1].Name;
                string pvalue = list_2[1].InnerText;
                string senior = list_2[1].Name;
                string svalue = list_2[1].InnerText;
                string numberofresults = list_2[2].Name;
                string nvval = list_2[2].InnerText;
                Championships c = new Championships(tvalue, pvalue, bool.Parse(svalue));
                championship_list.Add(c);
            }
            w.Close();
        }*/
    }

}

