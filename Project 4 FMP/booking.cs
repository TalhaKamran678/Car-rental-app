using System;
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
    public partial class booking : Form
    {
        public booking()
        {
            InitializeComponent();
            textBoxstreet.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void textBoxstreet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchTerm = textBoxstreet.Text.Trim().ToLower();

                switch (searchTerm)
                {
                    case "manchester":
                        this.Hide();
                        manchester manchester = new manchester();
                        manchester.ShowDialog();
                        break;

                    case "london":
                        this.Hide();
                        london london = new london();
                        london.ShowDialog();
                        break;

                    case "oxford":
                        this.Hide();
                        oxford oxford = new oxford();
                        oxford.ShowDialog();
                        break;

                    case "huddersfield":
                        this.Hide();
                        huddersfield huddersfield = new huddersfield();
                        huddersfield.ShowDialog();
                        break;

                    default:
                        MessageBox.Show("town does not exist");
                        break;
                }
            }
        }

        private void buttonbackbbok_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
