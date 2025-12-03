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
    public partial class oxford : Form
    {
        private string selectedCar = null;
        public oxford()
        {
            InitializeComponent();

            // Set car names manually using Tag
            ox1.Tag = "VolksWagen Golf 2019";
            ox2.Tag = "Land Rover 110 Defender 2024";
            ox3.Tag = "Dacia Sandero Stepway 2015";
            ox4.Tag = "BMW 3 Series 2024";
            ox5.Tag = "BMW 4 Series 2014";

            // Hook up click events
            ox1.Click += pictureBox_Click;
            ox2.Click += pictureBox_Click;
            ox3.Click += pictureBox_Click;
            ox4.Click += pictureBox_Click;
            ox5.Click += pictureBox_Click;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.BeginInvoke(new Action(() =>
            {
                this.AutoScrollPosition = new Point(0, 0);
                this.ActiveControl = oxmap; // Optional
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
            DateTime startDate = dateTimePickerpickupox.Value;
            DateTime endDate = dateTimePickerreturnox.Value;
            int numberOfDays = (endDate - startDate).Days + 1;

            if (numberOfDays < 0)
            {
                MessageBox.Show("End date must be after start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalPrice = numberOfDays * selectedPricePerDay;
            pricelabelox.Text = $"Price: £{totalPrice:0.00}";
        }

        private void oxford_Load(object sender, EventArgs e)
        {
            dateTimePickerpickupox.ValueChanged += UpdatePrice;
            dateTimePickerreturnox.ValueChanged += UpdatePrice;

            // Add click handlers for each picture box
            ox1.Click += (s, ev) => SelectCar(608.00m); // Car 1: $100/day
            ox2.Click += (s, ev) => SelectCar(368.00m); // Car 2: $120/day
            ox3.Click += (s, ev) => SelectCar(155.00m); // Car 3: $150/day
            ox4.Click += (s, ev) => SelectCar(249.00m);  // Car 4: $90/day
            ox5.Click += (s, ev) => SelectCar(249.00m); // Car 5: $110/day
        }
        private void SelectCar(decimal pricePerDay)
        {
            selectedPricePerDay = pricePerDay;
            UpdatePrice(null, null); // Recalculate price immediately after selecting a car
        }

        private void ChangeImageInPanel1(string imagePath)
        {
            // Load the image into the PictureBox inside the panel
            pictureBoxinfoox.Image = System.Drawing.Image.FromFile(imagePath);
        }
        private void ChangeImageInPanel2(string imagePath)
        {
            // Load the image into the PictureBox inside the panel
            pictureBoxinfoox2.Image = System.Drawing.Image.FromFile(imagePath);
        }

        private void ox1_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\oxford\car1\Screenshot 2025-05-19 135717.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\oxford\car1\Screenshot 2025-05-19 135808.png");
        }

        private void ox2_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\oxford\car2\Screenshot 2025-05-19 135836.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\oxford\car2\Screenshot 2025-05-19 135858.png");
        }

        private void ox3_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\oxford\car3\Screenshot 2025-05-19 135931.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\oxford\car3\Screenshot 2025-05-19 140015.png");
        }

        private void ox4_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\oxford\car4\Screenshot 2025-05-19 140048.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\oxford\car4\Screenshot 2025-05-19 140115.png");
        }

        private void ox5_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\oxford\car5\Screenshot 2025-05-19 140139.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\oxford\car5\Screenshot 2025-05-19 140212.png");
        }

        private void backox_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking booking = new booking();
            booking.ShowDialog();
        }

        private void confirmbookox_Click(object sender, EventArgs e)
        {
            string formName = this.Name;
            string carName = selectedCar ?? "None Selected";
            string date1 = dateTimePickerpickupox.Value.ToShortDateString();
            string date2 = dateTimePickerreturnox.Value.ToShortDateString();
            string combo1 = comboBoxpickupox.SelectedItem?.ToString() ?? "None";
            string combo2 = comboBoxreturnox.SelectedItem?.ToString() ?? "None";
            string prize = pricelabelox.Text;

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
