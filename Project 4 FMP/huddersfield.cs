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
    public partial class huddersfield : Form
    {
        private string selectedCar = null;
        public huddersfield()
        {
            InitializeComponent();

            // Set car names manually using Tag
            hud1.Tag = "VolksWagen Polo 2020";
            hud2.Tag = "Mercedes-Benz A-Class 2019";
            hud3.Tag = "Audi A3 2019";
            hud4.Tag = "Alfa Romeo Tonale 2023";
            hud5.Tag = "Peugeot 2008 2017";

            // Hook up click events
            hud1.Click += pictureBox_Click;
            hud2.Click += pictureBox_Click;
            hud3.Click += pictureBox_Click;
            hud4.Click += pictureBox_Click;
            hud5.Click += pictureBox_Click;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            this.BeginInvoke(new Action(() =>
            {
                this.AutoScrollPosition = new Point(0, 0);
                this.ActiveControl = hudmap; // Optional
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
            DateTime startDate = dateTimePickerpickuphud.Value;
            DateTime endDate = dateTimePickerreturnhud.Value;
            int numberOfDays = (endDate - startDate).Days + 1;

            if (numberOfDays < 0)
            {
                MessageBox.Show("End date must be after start date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal totalPrice = numberOfDays * selectedPricePerDay;
            pricelabelhud.Text = $"Price: £{totalPrice:0.00}";
        }

        private void huddersfield_Load(object sender, EventArgs e)
        {
            dateTimePickerpickuphud.ValueChanged += UpdatePrice;
            dateTimePickerreturnhud.ValueChanged += UpdatePrice;

            // Add click handlers for each picture box
            hud1.Click += (s, ev) => SelectCar(171.00m); // Car 1: $100/day
            hud2.Click += (s, ev) => SelectCar(437.00m); // Car 2: $120/day
            hud3.Click += (s, ev) => SelectCar(205.00m); // Car 3: $150/day
            hud4.Click += (s, ev) => SelectCar(241.00m);  // Car 4: $90/day
            hud5.Click += (s, ev) => SelectCar(219.00m); // Car 5: $110/day
        }
        private void SelectCar(decimal pricePerDay)
        {
            selectedPricePerDay = pricePerDay;
            UpdatePrice(null, null); // Recalculate price immediately after selecting a car
        }

        private void ChangeImageInPanel1(string imagePath)
        {
            // Load the image into the PictureBox inside the panel
            pictureBoxinfohud.Image = System.Drawing.Image.FromFile(imagePath);
        }
        private void ChangeImageInPanel2(string imagePath)
        {
            // Load the image into the PictureBox inside the panel
            pictureBoxinfohud2.Image = System.Drawing.Image.FromFile(imagePath);
        }

        private void hud1_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\huddersfield\car1\Screenshot 2025-05-19 130331.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\huddersfield\car1\Screenshot 2025-05-19 130459.png");
        }

        private void hud2_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\huddersfield\car2\Screenshot 2025-05-19 130534.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\huddersfield\car2\Screenshot 2025-05-19 130616.png");
        }

        private void hud3_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\huddersfield\car3\Screenshot 2025-05-19 130714.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\huddersfield\car3\Screenshot 2025-05-19 130745.png");
        }

        private void hud4_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\huddersfield\car4\Screenshot 2025-05-19 130814.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\huddersfield\car4\Screenshot 2025-05-19 130846.png");
        }

        private void hud5_Click(object sender, EventArgs e)
        {
            ChangeImageInPanel1(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\huddersfield\car5\Screenshot 2025-05-19 130923.png");
            ChangeImageInPanel2(@"C:\Users\2402168\OneDrive - Kirklees College\project 4 FMP\3.  Practicals Skills Folder\Project 4 FMP\Project 4 FMP\bin\Debug\net8.0-windows\info images\huddersfield\car5\Screenshot 2025-05-19 131001.png");
        }

        private void backhud_Click(object sender, EventArgs e)
        {
            this.Hide();
            booking booking = new booking();
            booking.ShowDialog();
        }

        private void confirmbookhud_Click(object sender, EventArgs e)
        {
            string formName = this.Name;
            string carName = selectedCar ?? "None Selected";
            string date1 = dateTimePickerpickuphud.Value.ToShortDateString();
            string date2 = dateTimePickerreturnhud.Value.ToShortDateString();
            string combo1 = comboBoxpickuphud.SelectedItem?.ToString() ?? "None";
            string combo2 = comboBoxreturnhud.SelectedItem?.ToString() ?? "None";
            string prize = pricelabelhud.Text;

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
