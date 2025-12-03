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
    public partial class london : Form
    {
        private string selectedCar = null;
        public london()
        {
            InitializeComponent();

            // Set car names manually using Tag
            lon1.Tag = "Nissan Versa 2021";
            lon2.Tag = "Kia K5 2021";
            lon3.Tag = "Bently Flying Spur 2021";
            lon4.Tag = "Kia Sorento 2023";
            lon5.Tag = "Mercedes-Benz Sprinter 2024";

            // Hook up click events
            lon1.Click += pictureBox_Click;
            lon2.Click += pictureBox_Click;
            lon3.Click += pictureBox_Click;
            lon4.Click += pictureBox_Click;
            lon5.Click += pictureBox_Click;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.BeginInvoke(new Action(() =>
            {
                this.AutoScrollPosition = new Point(0, 0);
                this.ActiveControl = lonmap; // Optional
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
            DateTime startDate = dateTimePickerpickuplon.Value;
            DateTime endDate = dateTimePickerreturnlon.Value;
            int numberOfDays = (endDate - startDate).Days + 1;

            if (numberOfDays < 0)
            {
                MessageBox.Show("End date must be after start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalPrice = numberOfDays * selectedPricePerDay;
            pricelabellon.Text = $"Price: £{totalPrice:0.00}";
        }

        private void london_Load(object sender, EventArgs e)
        {
            dateTimePickerpickuplon.ValueChanged += UpdatePrice;
            dateTimePickerreturnlon.ValueChanged += UpdatePrice;

            // Add click handlers for each picture box
            lon1.Click += (s, ev) => SelectCar(204.00m); // Car 1: $100/day
            lon2.Click += (s, ev) => SelectCar(342.00m); // Car 2: $120/day
            lon3.Click += (s, ev) => SelectCar(532.00m); // Car 3: $150/day
            lon4.Click += (s, ev) => SelectCar(392.00m);  // Car 4: $90/day
            lon5.Click += (s, ev) => SelectCar(915.00m); // Car 5: $110/day
        }
        private void SelectCar(decimal pricePerDay)
        {
            selectedPricePerDay = pricePerDay;
            UpdatePrice(null, null); // Recalculate price immediately after selecting a car
        }

        private void ChangeImageInPanel1(string imagePath)
        {
            // Load the image into the PictureBox inside the panel
            pictureBoxinfolon.Image = System.Drawing.Image.FromFile(imagePath);
        }
        private void ChangeImageInPanel2(string imagePath)
        {
            // Load the image into the PictureBox inside the panel
            pictureBoxinfolon2.Image = System.Drawing.Image.FromFile(imagePath);
        }

        private void lon1_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\london\car1\Screenshot 2025-05-20 092537.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\london\car1\Screenshot 2025-05-20 092607.png");
        }

        private void lon2_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\london\car2\Screenshot 2025-05-20 092646.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\london\car2\Screenshot 2025-05-20 092715.png");
        }

        private void lon3_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\london\car3\Screenshot 2025-05-20 092819.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\london\car3\Screenshot 2025-05-20 092844.png");
        }

        private void lon4_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\london\car4\Screenshot 2025-05-20 092913.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\london\car4\Screenshot 2025-05-20 092945.png");
        }

        private void lon5_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\london\car5\Screenshot 2025-05-20 093014.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\london\car5\Screenshot 2025-05-20 093038.png");
        }

        private void backlon_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking booking = new booking();
            booking.ShowDialog();
        }

        private void confirmbooklon_Click(object sender, EventArgs e)
        {
            string formName = this.Name;
            string carName = selectedCar ?? "None Selected";
            string date1 = dateTimePickerpickuplon.Value.ToShortDateString();
            string date2 = dateTimePickerreturnlon.Value.ToShortDateString();
            string combo1 = comboBoxpickuplon.SelectedItem?.ToString() ?? "None";
            string combo2 = comboBoxreturnlon.SelectedItem?.ToString() ?? "None";
            string prize = pricelabellon.Text;

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
