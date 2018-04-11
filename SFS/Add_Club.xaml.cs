using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Data;
namespace SFS
{
    /// <summary>
    /// Interaction logic for Add_Club.xaml
    /// </summary>
    public partial class Add_Club : Window
    {
        public Add_Club()
        {
            InitializeComponent();
        }

       
        private void button_Click(object sender, RoutedEventArgs e)
        {
            Add_Options cccc = new Add_Options();
            cccc.Show();
        }


        private void button2_Click(object sender, RoutedEventArgs e)
        {
            int x = 0;
            string st =x.ToString();
            if (Name.Text == "" || starting.Text=="")
            {
                MessageBox.Show("Please fill the required information !");
            }

           else  if (!File.Exists("Clubs.xml"))
            {
                XmlTextWriter document = new XmlTextWriter("Clubs.xml", Encoding.UTF8);

                document.Formatting = Formatting.Indented;
                document.WriteStartDocument();
                document.WriteStartElement("Clubs");
                document.WriteStartElement("Club");

                document.WriteStartElement("Club_Name");
                document.WriteString(Name.Text);
                document.WriteEndElement();

                document.WriteStartElement("Starting_Date");
                document.WriteString(starting.Text);
                document.WriteEndElement();

                document.WriteStartElement("Club_Teams");
                document.WriteString(st);
                document.WriteEndElement();

                document.WriteStartElement("Club_Championships");
                document.WriteString(st);
                document.WriteEndElement();

                document.WriteStartElement("Club_Sponsors");
                document.WriteString(st);
                document.WriteEndElement();

                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();

                MessageBox.Show("Club Successfuly Added.");
            }
            else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Clubs.xml");

                XmlNode clubss = doc.CreateElement("Club");

                XmlNode club_Name = doc.CreateElement("Club_Name");
                club_Name.InnerText = Name.Text;
                clubss.AppendChild(club_Name);

                XmlNode Starting = doc.CreateElement("starting_Date");
                Starting.InnerText = starting.Text;
                clubss.AppendChild(Starting);

                XmlNode Clubteams = doc.CreateElement("Club_Teams");
                Clubteams.InnerText = st;
                clubss.AppendChild(Clubteams);

                XmlNode champion = doc.CreateElement("Club_Championships");
                champion.InnerText = st;
                clubss.AppendChild(champion);

                XmlNode sponsor = doc.CreateElement("Club_Sponsors");
                sponsor.InnerText = st;
                clubss.AppendChild(sponsor);

                doc.DocumentElement.AppendChild(clubss);
                doc.Save("Clubs.xml");

                MessageBox.Show("Club Successfuly Added.");
            }
           
        }
    }
}
