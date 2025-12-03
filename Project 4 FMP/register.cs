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

namespace Project_4_FMP
{
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        string filepath = @"C:\\Users\\2402168\\OneDrive - Kirklees College\\project 4 FMP\\3.  Practicals Skills Folder\\Project 4 FMP\\Project 4 FMP\\bin\\Debug\\net8.0-windows\\users.csv";

        ArrayList allusernames = new ArrayList();
        Dictionary<string, string> usernameANDpassword = new Dictionary<string, string>();

        public void getUsers()
        {
            string[] lines = File.ReadAllLines(filepath);
            string[] values;
            string un = "";
            string ps = "";

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(',');

                if (values[0].Trim().Equals("Username"))
                {
                    un = values[1];
                    allusernames.Add(un);
                }
                else if (values[0].Trim().Equals("Password"))
                {
                    ps = values[1];
                }
                if (un != "" && ps != "")
                {
                    usernameANDpassword.Add(un, ps);
                    un = "";
                    ps = "";
                }

            }

        }

        private void buttonback2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void buttonregister_Click(object sender, EventArgs e)
        {
            string username = textboxusername.Text;
            string email = textboxemail.Text;
            string password = textboxpassword.Text;
            string confirmpassword = textboxconfirm.Text;

            if (!username.Trim().Equals("") && !email.Trim().Equals("") && !password.Trim().Equals(""))
            {
                // Check if user already exists by reading from file
                bool userExists = false;
                if (File.Exists(filepath))
                {
                    string[] lines = File.ReadAllLines(filepath);
                    foreach (string line in lines)
                    {
                        string[] userDetails = line.Split(',');
                        if (userDetails.Length >= 3 && userDetails[0].Trim() == username.Trim())
                        {
                            userExists = true;
                            break; // No need to continue checking further lines if user already exists
                        }
                    }
                }

                if (userExists)
                {
                    MessageBox.Show("This user already has an account", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (password.Equals(confirmpassword))
                    {
                        // Proceed with writing the new user details to the file
                        TextWriter writer = new StreamWriter(filepath, true);
                        writer.Write(username);
                        writer.Write(",");
                        writer.Write(email);
                        writer.Write(",");
                        writer.Write(password);
                        writer.WriteLine("");

                        writer.Close();
                        MessageBox.Show("Account created", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        usernameANDpassword.Add(username, password);

                        this.Hide();
                        login login = new login();
                        login.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Confirmation Password Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttontrylogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            login login = new login();
            login.ShowDialog();
        }

        private void register_Load(object sender, EventArgs e)
        {
            string filepath = @"C:\\Users\\2402168\\OneDrive - Kirklees College\\project 4 FMP\\3.  Practicals Skills Folder\\Project 4 FMP\\Project 4 FMP\\bin\\Debug\\net8.0-windows\\users.csv";
        }
    }
}
