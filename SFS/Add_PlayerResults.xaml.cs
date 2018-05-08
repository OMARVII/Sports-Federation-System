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
    /// Interaction logic for Add_PlayerResults.xaml
    /// </summary>
    public partial class Add_PlayerResults : Window
    {
        public Add_PlayerResults()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bool ch_found = false;
            
            for (int i = 0; i < Containers.championship_list.Count; i++)
            {
                if (Containers.championship_list[i].getName() == name1.Text && Containers.championship_list[i].GetPlace() == places.Text && Containers.championship_list[i].Gettype() == typee.Text)

                {
                    ch_found = true;
                }
            }
            if (ch_found==false)
            {
                MessageBox.Show("Please Enter a Valid ChampionShip");
            }
            else
            {
                string coachname = "";
                int x = int.Parse(result.Text);
                if (typee.Text == "" || result.Text == "")
                {
                    MessageBox.Show("Please fill the required information !");
                }
                else
                {
                    for (int i = 0; i < Containers.Player_list.Count; i++)
                    {
                        if (Containers.Player_list[i].getId().ToString() == Enter_ID.playerid)
                        {
                            coachname = Containers.Player_list[i].get_CoachName();
                        }

                    }
                    for (int i = 0; i < Containers.Coach_list.Count; i++)
                    {
                        if (Containers.Coach_list[i].getName() == coachname)
                        {
                            Containers.Coach_list[i].setResult(Containers.Coach_list[i].getResult() + x);
                            break;
                        }
                    }

                    if (File.Exists("Coaches.xml"))
                    {
                        File.Delete("Coaches.xml");
                    }

                    for (int i = 0; i < Containers.Coach_list.Count; i++)
                    {
                        Containers.write_coach(Containers.Coach_list[i]);

                    }

                    if (!File.Exists("Results.xml"))
                    {
                        XmlTextWriter document = new XmlTextWriter("Results.xml", Encoding.UTF8);

                        document.Formatting = Formatting.Indented;
                        document.WriteStartDocument();
                        document.WriteStartElement("Results");
                        document.WriteStartElement("Result");

                        document.WriteStartElement("Player_ID");
                        document.WriteString(Enter_ID.playerid);
                        document.WriteEndElement();

                        document.WriteStartElement("Championship_Type");
                        document.WriteString(typee.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Championship_Place");
                        document.WriteString(places.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Results");
                        document.WriteString(result.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Name");
                        document.WriteString(name1.Text);
                        document.WriteEndElement();

                        document.WriteEndElement();
                        document.WriteEndElement();
                        document.WriteEndDocument();

                        document.Close();

                        MessageBox.Show("Player Results Successfuly added.");

                    }
                    else

                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load("Results.xml");

                        XmlNode resultt = doc.CreateElement("Result");

                        XmlNode id = doc.CreateElement("Player_ID");
                        id.InnerText = Enter_ID.playerid;
                        resultt.AppendChild(id);

                        XmlNode type = doc.CreateElement("Championship_Type");
                        type.InnerText = typee.Text;
                        resultt.AppendChild(type);

                        XmlNode placee = doc.CreateElement("Championship_Place");
                        placee.InnerText = places.Text;
                        resultt.AppendChild(placee);

                        XmlNode res = doc.CreateElement("Results");
                        res.InnerText = result.Text;
                        resultt.AppendChild(res);

                        XmlNode names = doc.CreateElement("Name");
                        names.InnerText = name1.Text;
                        resultt.AppendChild(names);

                        doc.DocumentElement.AppendChild(resultt);
                        doc.Save("Results.xml");

                        MessageBox.Show("Player Result Successfuly added.");
                    }
                }
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Edit_Player pp = new Edit_Player();
            pp.Show();
            this.Close();
        }

        private void name1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            adminoptions a = new adminoptions();
            a.Show();
            this.Close();
        }

        private void result_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(result.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only !");
                result.Text = result.Text.Remove(result.Text.Length - 1);
            }
        }
    }
}
