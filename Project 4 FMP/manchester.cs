using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.Marshalling.IIUnknownCacheStrategy;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_4_FMP
{
    public partial class manchester : Form
    {
        private string selectedCar = null;

        public manchester()
        {
            InitializeComponent();

            // Set car names manually using Tag
            man1.Tag = "VolksWagen Golf 2020";
            man2.Tag = "BMW X1 2015";
            man3.Tag = "Ford Explorer 2024";
            man4.Tag = "Alfa Romeo Giulietta 2015";
            man5.Tag = "Mercedes-Benz EQC 2023";

            // Hook up click events
            man1.Click += pictureBox_Click;
            man2.Click += pictureBox_Click;
            man3.Click += pictureBox_Click;
            man4.Click += pictureBox_Click;
            man5.Click += pictureBox_Click;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.BeginInvoke(new Action(() =>
            {
                this.AutoScrollPosition = new Point(0, 0);
                this.ActiveControl = manmap; // Optional
            }));
        }


        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;
            if (clickedPictureBox != null && clickedPictureBox.Tag != null)
            {
                selectedCar = clickedPictureBox.Tag.ToString();
            }
        }

        private decimal selectedPricePerDay = 0.00m; // Default value

        private void UpdatePrice(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePickerpickupman.Value;
            DateTime endDate = dateTimePickerreturnman.Value;
            int numberOfDays = (endDate - startDate).Days + 1;

            if (numberOfDays < 0)
            {
                MessageBox.Show("End date must be after start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalPrice = numberOfDays * selectedPricePerDay;
            pricelabelman.Text = $"Price: £{totalPrice:0.00}";
        }

        private void manchester_Load(object sender, EventArgs e)
        {
            dateTimePickerpickupman.ValueChanged += UpdatePrice;
            dateTimePickerreturnman.ValueChanged += UpdatePrice;

            // Add click handlers for each picture box
            man1.Click += (s, ev) => SelectCar(186.00m); // Car 1: $100/day
            man2.Click += (s, ev) => SelectCar(178.00m); // Car 2: $120/day
            man3.Click += (s, ev) => SelectCar(279.00m); // Car 3: $150/day
            man4.Click += (s, ev) => SelectCar(162.00m);  // Car 4: $90/day
            man5.Click += (s, ev) => SelectCar(340.00m); // Car 5: $110/day
        }
        private void SelectCar(decimal pricePerDay)
        {
            selectedPricePerDay = pricePerDay;
            UpdatePrice(null, null); // Recalculate price immediately after selecting a car
        }


        private void ChangeImageInPanel1(string imagePath)
        {
            // Load the image into the PictureBox inside the panel
            pictureBoxinfoman.Image = System.Drawing.Image.FromFile(imagePath);
        }
        private void ChangeImageInPanel2(string imagePath)
        {
            // Load the image into the PictureBox inside the panel
            pictureBoxinfoman2.Image = System.Drawing.Image.FromFile(imagePath);
        }

        private void man1_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\manchester\car1\Screenshot 2025-05-19 104338.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\manchester\car1\Screenshot 2025-05-19 111302.png");
        }

        private void man2_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\manchester\car2\Screenshot 2025-05-19 120315.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\manchester\car2\Screenshot 2025-05-19 120412.png");
        }

        private void man3_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\manchester\car3\Screenshot 2025-05-19 121657.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\manchester\car3\Screenshot 2025-05-19 121740.png");
        }

        private void man4_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\manchester\car4\Screenshot 2025-05-19 121910.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\manchester\car4\Screenshot 2025-05-19 121938.png");
        }

        private void man5_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\manchester\car5\Screenshot 2025-05-19 122057.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\manchester\car5\Screenshot 2025-05-19 122126.png");
        }

        private void backman_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking booking = new booking();
            booking.ShowDialog();
        }

        private void confirmbookman_Click(object sender, EventArgs e)
        {
            string formName = this.Name;
            string carName = selectedCar ?? "None Selected";
            string date1 = dateTimePickerpickupman.Value.ToShortDateString();
            string date2 = dateTimePickerreturnman.Value.ToShortDateString();
            string combo1 = comboBoxpickupman.SelectedItem?.ToString() ?? "None";
            string combo2 = comboBoxreturnman.SelectedItem?.ToString() ?? "None";
            string prize = pricelabelman.Text;

            string[] data = { formName, carName, date1, date2, combo1, combo2, prize };
            string csvLine = string.Join(",", data);

            string FilePath = @"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\booking.csv";
            bool fileExists = File.Exists(FilePath);

            using (StreamWriter sw = new StreamWriter(FilePath, true))
            {
                if (!fileExists)
                {
                    sw.WriteLine("Form Name,Car Name,Date 1,Date 2,Combo 1,Combo 2,Prize");
                }
                sw.WriteLine(csvLine);
            }

            MessageBox.Show("Booking Done");
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
