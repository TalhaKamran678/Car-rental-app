namespace Project_4_FMP
{
    partial class booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(booking));
            labelcity = new Label();
            textBoxstreet = new TextBox();
            labeltopbooking = new Label();
            placeselector = new PictureBox();
            buttonbackbbok = new Button();
            labelbookplacelist = new Label();
            labelbookplacelistman = new Label();
            labelbookplacelistlon = new Label();
            labelbookplacelistox = new Label();
            labelbookplacelisthud = new Label();
            ((System.ComponentModel.ISupportInitialize)placeselector).BeginInit();
            SuspendLayout();
            // 
            // labelcity
            // 
            labelcity.Anchor = AnchorStyles.None;
            labelcity.AutoSize = true;
            labelcity.BackColor = Color.FromArgb(0, 229, 255);
            labelcity.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelcity.ForeColor = Color.Black;
            labelcity.Location = new Point(315, 374);
            labelcity.Name = "labelcity";
            labelcity.Size = new Size(98, 23);
            labelcity.TabIndex = 1;
            labelcity.Text = "City/Town:";
            // 
            // textBoxstreet
            // 
            textBoxstreet.Anchor = AnchorStyles.None;
            textBoxstreet.AutoCompleteCustomSource.AddRange(new string[] { "Manchester", "London", "Huddersfield", "Oxford" });
            textBoxstreet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxstreet.Location = new Point(315, 410);
            textBoxstreet.Name = "textBoxstreet";
            textBoxstreet.Size = new Size(355, 23);
            textBoxstreet.TabIndex = 4;
            textBoxstreet.KeyDown += textBoxstreet_KeyDown;
            // 
            // labeltopbooking
            // 
            labeltopbooking.Anchor = AnchorStyles.Top;
            labeltopbooking.AutoSize = true;
            labeltopbooking.Font = new Font("Kristen ITC", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labeltopbooking.ForeColor = SystemColors.ButtonHighlight;
            labeltopbooking.Location = new Point(287, 62);
            labeltopbooking.Name = "labeltopbooking";
            labeltopbooking.Size = new Size(430, 131);
            labeltopbooking.TabIndex = 9;
            labeltopbooking.Text = "Booking";
            // 
            // placeselector
            // 
            placeselector.Anchor = AnchorStyles.None;
            placeselector.Image = (Image)resources.GetObject("placeselector.Image");
            placeselector.Location = new Point(298, 361);
            placeselector.Name = "placeselector";
            placeselector.Size = new Size(392, 81);
            placeselector.SizeMode = PictureBoxSizeMode.AutoSize;
            placeselector.TabIndex = 10;
            placeselector.TabStop = false;
            // 
            // buttonbackbbok
            // 
            buttonbackbbok.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonbackbbok.BackColor = Color.FromArgb(0, 229, 225);
            buttonbackbbok.BackgroundImageLayout = ImageLayout.None;
            buttonbackbbok.FlatAppearance.BorderSize = 0;
            buttonbackbbok.FlatStyle = FlatStyle.Flat;
            buttonbackbbok.Font = new Font("Kristen ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonbackbbok.Location = new Point(12, 458);
            buttonbackbbok.Name = "buttonbackbbok";
            buttonbackbbok.Size = new Size(95, 37);
            buttonbackbbok.TabIndex = 11;
            buttonbackbbok.Text = "Back";
            buttonbackbbok.UseVisualStyleBackColor = false;
            buttonbackbbok.Click += buttonbackbbok_Click;
            // 
            // labelbookplacelist
            // 
            labelbookplacelist.AutoSize = true;
            labelbookplacelist.Font = new Font("Kristen ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelbookplacelist.ForeColor = SystemColors.ButtonHighlight;
            labelbookplacelist.Location = new Point(316, 193);
            labelbookplacelist.Name = "labelbookplacelist";
            labelbookplacelist.Size = new Size(184, 29);
            labelbookplacelist.TabIndex = 12;
            labelbookplacelist.Text = "Available Cities:";
            // 
            // labelbookplacelistman
            // 
            labelbookplacelistman.AutoSize = true;
            labelbookplacelistman.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelbookplacelistman.ForeColor = SystemColors.ButtonHighlight;
            labelbookplacelistman.Location = new Point(329, 237);
            labelbookplacelistman.Name = "labelbookplacelistman";
            labelbookplacelistman.Size = new Size(106, 23);
            labelbookplacelistman.TabIndex = 13;
            labelbookplacelistman.Text = "Manchester";
            // 
            // labelbookplacelistlon
            // 
            labelbookplacelistlon.AutoSize = true;
            labelbookplacelistlon.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelbookplacelistlon.ForeColor = SystemColors.ButtonHighlight;
            labelbookplacelistlon.Location = new Point(329, 269);
            labelbookplacelistlon.Name = "labelbookplacelistlon";
            labelbookplacelistlon.Size = new Size(72, 23);
            labelbookplacelistlon.TabIndex = 14;
            labelbookplacelistlon.Text = "London";
            // 
            // labelbookplacelistox
            // 
            labelbookplacelistox.AutoSize = true;
            labelbookplacelistox.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelbookplacelistox.ForeColor = SystemColors.ButtonHighlight;
            labelbookplacelistox.Location = new Point(329, 297);
            labelbookplacelistox.Name = "labelbookplacelistox";
            labelbookplacelistox.Size = new Size(68, 23);
            labelbookplacelistox.TabIndex = 15;
            labelbookplacelistox.Text = "Oxford";
            // 
            // labelbookplacelisthud
            // 
            labelbookplacelisthud.AutoSize = true;
            labelbookplacelisthud.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelbookplacelisthud.ForeColor = SystemColors.ButtonHighlight;
            labelbookplacelisthud.Location = new Point(329, 326);
            labelbookplacelisthud.Name = "labelbookplacelisthud";
            labelbookplacelisthud.Size = new Size(112, 23);
            labelbookplacelisthud.TabIndex = 16;
            labelbookplacelisthud.Text = "Huddersfield";
            // 
            // booking
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(255, 26, 60);
            ClientSize = new Size(1002, 507);
            Controls.Add(labelbookplacelisthud);
            Controls.Add(labelbookplacelistox);
            Controls.Add(labelbookplacelistlon);
            Controls.Add(labelbookplacelistman);
            Controls.Add(labelbookplacelist);
            Controls.Add(buttonbackbbok);
            Controls.Add(labelcity);
            Controls.Add(textBoxstreet);
            Controls.Add(labeltopbooking);
            Controls.Add(placeselector);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "booking";
            ((System.ComponentModel.ISupportInitialize)placeselector).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelcity;
        private TextBox textBoxstreet;
        private Label labeltopbooking;
        private PictureBox placeselector;
        private Button buttonbackbbok;
        private Label labelbookplacelist;
        private Label labelbookplacelistman;
        private Label labelbookplacelistlon;
        private Label labelbookplacelistox;
        private Label labelbookplacelisthud;
    }
}