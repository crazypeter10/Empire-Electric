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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Xml;
using System.IO;
using System.Collections.Generic;

namespace Proiect_APB
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        EmpireElectricEntities context = new EmpireElectricEntities();
        string email;
        public Window2(string _email)
        {
            InitializeComponent();
            email = _email;
            userText.Text = _email;
        }

        private static string getFilePath(string fileName)
        {
            return System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
        }
        private void Button_Click_Xml(object sender, RoutedEventArgs e)
        {

            var accounts = from a in context.customers
                           select a;
            var listAccounts = accounts.ToList();
            var xmlDoc = new XmlDocument();
            xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", "utf-8", null));
            var el = xmlDoc.CreateElement("Accounts");
            xmlDoc.AppendChild(el);

            for (int i = 0; i < accounts.Count(); i++)
            {
                var child = xmlDoc.CreateElement("Account");

                var attribute1 = xmlDoc.CreateAttribute("AccountId");
                attribute1.Value = listAccounts[i].cust_id.ToString();

                var attribute2 = xmlDoc.CreateAttribute("Password");
                attribute2.Value = listAccounts[i].passsword.ToString();

                var attribute3 = xmlDoc.CreateAttribute("Username");
                attribute3.Value = listAccounts[i].email_id;

                var attribute4 = xmlDoc.CreateAttribute("Email");
                attribute4.Value = listAccounts[i].email_id;


                child.Attributes.Append(attribute1);
                child.Attributes.Append(attribute3);
                child.Attributes.Append(attribute2);
                child.Attributes.Append(attribute4);

                el.AppendChild(child);
            }
            xmlDoc.Save(getFilePath("XmlAccounts.xml"));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;

            this.Hide();
            var form2 = new admin_mo_pay(user);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;

            this.Hide();
            var form2 = new admin_tarrifs(user);
            form2.Closed += (s, args) => this.Close();
            form2.Show();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;

            this.Hide();
            var form3 = new admin_feedbacks(user);
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string user = userText.Text;

            var q = (from a in context.admins
                     where a.login_id.Equals(user)
                     select a).FirstOrDefault();
            if (q != null)
            {
                Text_1.Text = "Name" + q.admin_name + " Function " + q.admin_type;
            }
        }
    }
}


