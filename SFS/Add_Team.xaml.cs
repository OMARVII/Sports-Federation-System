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
    /// Interaction logic for Add_Team.xaml
    /// </summary>
    public partial class Add_Team : Window
    {
        public Add_Team()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            string sen;
            if (Senior.IsChecked == true)
                sen = "Yes";
            else sen = "No";

            if (!File.Exists("Teams.xml"))
            {
                XmlTextWriter document = new XmlTextWriter("Teams.xml", Encoding.UTF8);

                document.Formatting = Formatting.Indented;
                document.WriteStartDocument();
                document.WriteStartElement("Teams");
                document.WriteStartElement("Team");

                document.WriteStartElement("Team_Name");
                document.WriteString(Name.Text);
                document.WriteEndElement();

                document.WriteStartElement("Senior");
                document.WriteString(sen);
                document.WriteEndElement();

                document.WriteStartElement("Results");
                document.WriteString(Results.Text);
                document.WriteEndElement();

                document.WriteEndElement();
                document.WriteEndElement();
                document.WriteEndDocument();

                document.Close();

            }
            else

            {
                XmlDocument doc = new XmlDocument();
                doc.Load("Teams.xml");

                XmlNode team = doc.CreateElement("Team");

                XmlNode team_Name = doc.CreateElement("Team_Name");
                team_Name.InnerText = Name.Text;
                team.AppendChild(team_Name);

                XmlNode senior = doc.CreateElement("Senior");
                senior.InnerText = sen;
                team.AppendChild(senior);

                XmlNode res = doc.CreateElement("Results");
                res.InnerText = Results.Text;
                team.AppendChild(res);

                doc.DocumentElement.AppendChild(team);
                doc.Save("Teams.xml");
            }
        }
    }
}
