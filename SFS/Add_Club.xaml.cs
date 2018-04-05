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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if (!File.Exists("Clubs.xml"))
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
                document.WriteString(Starting_.Text);
                document.WriteEndElement();

                document.WriteStartElement("Club_Teams");
                document.WriteString(Team.Text);
                document.WriteEndElement();

                document.WriteStartElement("Club_Championships");
                document.WriteString(Champion.Text);
                document.WriteEndElement();

                document.WriteStartElement("Club_Sponsors");
                document.WriteString(sponsors.Text);
                document.WriteEndElement();

                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();
            }
            else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Clubs.xml");

                XmlNode clubss = doc.CreateElement("Club");

                XmlNode club_Name = doc.CreateElement("Club_Name");
                club_Name.InnerText = Name.Text;
                clubss.AppendChild(club_Name);

                XmlNode starting = doc.CreateElement("starting_Date");
                starting.InnerText = Starting_.Text;
                clubss.AppendChild(starting);

                XmlNode Clubteams = doc.CreateElement("Club_Teams");
                Clubteams.InnerText = Team.Text;
                clubss.AppendChild(Clubteams);

                XmlNode champion = doc.CreateElement("Club_Championships");
                champion.InnerText = Champion.Text;
                clubss.AppendChild(champion);

                XmlNode sponsor = doc.CreateElement("Club_Sponsors");
                sponsor.InnerText = sponsors.Text;
                clubss.AppendChild(sponsor);

                doc.DocumentElement.AppendChild(clubss);
                doc.Save("Clubs.xml");
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Chooose cccc = new Chooose();
            cccc.Show();
        }
    }
}
