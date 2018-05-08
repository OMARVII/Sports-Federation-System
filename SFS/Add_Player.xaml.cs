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
    /// Interaction logic for Add_Player.xaml
    /// </summary>
    public partial class Add_Player : Window
    {
        public Add_Player()
        {
            InitializeComponent();
        }
       
        private void button_Click(object sender, RoutedEventArgs e)
        {

            if (player_name.Text == "" || Number.Text == "" || names.Text == "" || Date.Text == "" || club.Text == "")
            {
                MessageBox.Show("Please fill the required information !");
            }
            else if (Number.Text.Length != 11)
            {
                MessageBox.Show("Please Enter Valid Mobile Number!");
            }
            else if ((male.IsChecked == true) && (female.IsChecked == true))
                MessageBox.Show("Please fill the required information !");
            else if ((yes.IsChecked == true) && (no.IsChecked == true))
                MessageBox.Show("Please fill the required information !");


            else
            {

                string gender;
                string med;
                int x = 0;
                string bou = x.ToString();
                int y = int.Parse(Date.Text.Substring(6));

                string salaryy = "0";
                if (names.Text == "Women" || names.Text == "Men")
                {
                    salaryy = "2000";
                }

                if (male.IsChecked == true)
                    gender = "Male";
                else gender = "Female";
                if (yes.IsChecked == true)
                    med = "YES";
                else med = "NO";
                string temp = Date.Text;
                string temp2 = player_name.Text;
                string id = "";
                bool mobile = false;
                Person.count2++;


                if (temp.Length == 10)
                {
                    id = Person.count2 + temp2[0].ToString() + temp2[1].ToString() + temp[8].ToString() + temp[9].ToString();
                }
                else if (temp.Length == 9)
                {
                    id = Person.count2 + temp2[0].ToString() + temp2[1].ToString() + temp[7].ToString() + temp[8].ToString();
                }
                else if (temp.Length == 8)
                {
                    id = Person.count2 + temp2[0].ToString() + temp2[1].ToString() + temp[6].ToString() + temp[7].ToString();
                }



                Player p = new Player(player_name.Text, Date.Text, gender, id, med, float.Parse(salaryy), x, Number.Text, names.Text, coach.Text, club.Text);

                bool mobilee = false;
                for (int i = 0; i < Containers.Player_list.Count(); i++)
                {
                    if (Containers.Player_list[i].getmobile() == Number.Text)
                    {
                        mobilee = true;
                    }
                }
                for (int i = 0; i < Containers.Employee_list.Count(); i++)
                {
                    if (Containers.Employee_list[i].getmobile() == Number.Text)
                    {
                        mobilee = true;
                    }
                }
                bool coachh = false, clubbl = false;
                for (int i = 0; i < Containers.Club_list.Count; i++)
                {
                    if (club.Text == Containers.Club_list[i].getClubName())
                    {
                        clubbl = true;
                    }

                }

                for (int i = 0; i < Containers.Coach_list.Count; i++)
                {
                    if (coach.Text == Containers.Coach_list[i].getName())
                    {
                        coachh = true;
                    }

                }
                if (mobilee == true)
                {
                    MessageBox.Show("Please Re-enter Mobile Number !");
                }
                else if(coachh==false)
                {
                    MessageBox.Show("Coach doesn't exist ! ");
                }   
                else if (clubbl == false)
                {
                    MessageBox.Show("Club Does not Exists !");
                }
                else
                {

                    Containers.Player_list.Add(p);
                    if (!File.Exists("Players.xml"))
                    {

                        XmlTextWriter document = new XmlTextWriter("Players.xml", Encoding.UTF8);

                        document.Formatting = Formatting.Indented;
                        document.WriteStartDocument();
                        document.WriteStartElement("Players");
                        document.WriteStartElement("Player");

                        document.WriteStartElement("Player_Name");
                        document.WriteString(player_name.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Player_ID");
                        document.WriteString(id);
                        document.WriteEndElement();

                        document.WriteStartElement("Mobile_Number");
                        document.WriteString(Number.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Gender");
                        document.WriteString(gender);
                        document.WriteEndElement();

                        document.WriteStartElement("Medical_Form");
                        document.WriteString(med);
                        document.WriteEndElement();

                        document.WriteStartElement("Salary");
                        document.WriteString(salaryy);
                        document.WriteEndElement();

                        document.WriteStartElement("Bonus");
                        document.WriteString(bou);
                        document.WriteEndElement();

                        document.WriteStartElement("Date_of_birth");
                        document.WriteString(Date.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Team_Name");
                        document.WriteString(names.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Coach_Name");
                        document.WriteString(coach.Text);
                        document.WriteEndElement();

                        document.WriteStartElement("Club_Name");
                        document.WriteString(club.Text);
                        document.WriteEndElement();

                        document.WriteEndElement();
                        document.WriteEndElement();
                        document.WriteEndDocument();

                        document.Close();

                        MessageBox.Show("Player Successfuly Added.");
                    }
                    else

                    {
                        XmlDocument doc = new XmlDocument();
                        doc.Load("Players.xml");

                        XmlNode playerr = doc.CreateElement("Player");

                        XmlNode Player_Name = doc.CreateElement("Player_Name");
                        Player_Name.InnerText = player_name.Text;
                        playerr.AppendChild(Player_Name);

                        XmlNode ID = doc.CreateElement("Player_ID");
                        ID.InnerText = id;
                        playerr.AppendChild(ID);

                        XmlNode MobileNum = doc.CreateElement("Mobile_Number");
                        MobileNum.InnerText = Number.Text;
                        playerr.AppendChild(MobileNum);

                        XmlNode Genderr = doc.CreateElement("Gender");
                        Genderr.InnerText = gender;
                        playerr.AppendChild(Genderr);

                        XmlNode Medical = doc.CreateElement("Medical_Form");
                        Medical.InnerText = med;
                        playerr.AppendChild(Medical);

                        XmlNode salary = doc.CreateElement("Salary");
                        salary.InnerText = salaryy;
                        playerr.AppendChild(salary);

                        XmlNode bonus = doc.CreateElement("Bonus");
                        bonus.InnerText = bou;
                        playerr.AppendChild(bonus);

                        XmlNode dateofbirth = doc.CreateElement("Date_oF_birth");
                        dateofbirth.InnerText = Date.Text;
                        playerr.AppendChild(dateofbirth);

                        XmlNode teamm = doc.CreateElement("Team_Name");
                        teamm.InnerText = names.Text;
                        playerr.AppendChild(teamm);

                        XmlNode cooo = doc.CreateElement("Coach_Name");
                        cooo.InnerText = coach.Text;
                        playerr.AppendChild(cooo);

                        XmlNode clubb = doc.CreateElement("Club_Name");
                        clubb.InnerText = club.Text;
                        playerr.AppendChild(clubb);

                        doc.DocumentElement.AppendChild(playerr);
                        doc.Save("Players.xml");

                        MessageBox.Show("Player Successfuly Added.");
                    }
                    Containers.write_counter2();
                }
            }
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            Add_Options cccc = new Add_Options();
            cccc.Show();
            this.Close();
        }

        private void yes_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            adminoptions o = new adminoptions();
            o.Show();
            this.Close();
        }

        private void Number_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(Number.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter numbers only !");
                Number.Text = Number.Text.Remove(Number.Text.Length - 1);
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
    }

