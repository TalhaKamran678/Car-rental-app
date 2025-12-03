using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Project_4_FMP
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        string filepath = @"C:\\Users\\2402168\\OneDrive - Kirklees College\\project 4 FMP\\3.  Practicals Skills Folder\\Project 4 FMP\\Project 4 FMP\\bin\\Debug\\net8.0-windows\\users.csv";

        ArrayList allusernames = new ArrayList();
        Dictionary<string, string> usernameANDpassword = new Dictionary<string, string>();

        public void getUsers()
        {
            string[] lines = File.ReadAllLines(filepath); // Read all lines from the text file
            string[] values;
            string un = "";
            string ps = "";

            for (int i = 0; i < lines.Length; i++)
            {
                // Split the line by the comma to separate username, password, email, and full name
                values = lines[i].ToString().Split(',');

                // Ensure there are at least two values (username and password) and discard the rest
                if (values.Length >= 2)
                {
                    un = values[0].Trim(); // Username is the first value
                    ps = values[2].Trim(); // Password is the second value

                    if (!string.IsNullOrEmpty(un) && !string.IsNullOrEmpty(ps))
                    {
                        // Add the username and password to the dictionary
                        usernameANDpassword.Add(un, ps);

                        // Optionally, add the username to a separate list if needed
                        allusernames.Add(un);
                    }
                }
            }
        }


        private void buttonback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttontryregister_Click(object sender, EventArgs e)
        {
            this.Hide();
            register registration = new register();
            registration.ShowDialog();
        }

        private void buttonlogin_Click(object sender, EventArgs e)
        {
            string username = textBoxusername.Text;
            string password = textBoxpassword.Text;
            bool userExist = false;

            if (username.Trim().Equals("") || password.Trim().Equals(""))
            {
                MessageBox.Show("You need to enter the username and password", "Empty feilds", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                foreach (var uname in usernameANDpassword)
                {
                    if (uname.Key.ToString().Trim().Equals(username))
                    {
                        if (uname.Value.ToString().Trim().Equals(password))
                        {
                            userExist = true;
                            break;
                        }
                    }
                }
                if (userExist)
                {
                    MessageBox.Show("Login Succesfull", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    booking booking = new booking();
                    booking.ShowDialog();
                }
                else
                {
                    MessageBox.Show("This user does not exist", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            string filepath = @"C:\\Users\\2402168\\OneDrive - Kirklees College\\project 4 FMP\\3.  Practicals Skills Folder\\Project 4 FMP\\Project 4 FMP\\bin\\Debug\\net8.0-windows\\users.csv";
            getUsers();
        }
    }
}
