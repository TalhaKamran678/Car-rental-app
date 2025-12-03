namespace Project_4_FMP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toplayer = new Panel();
            buttonbooknow = new Button();
            logo = new PictureBox();
            infobackground = new Panel();
            infotext3 = new TextBox();
            info3 = new PictureBox();
            panelspot = new Panel();
            infotext1 = new TextBox();
            infotext2 = new TextBox();
            info1 = new PictureBox();
            info2 = new PictureBox();
            toplayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            infobackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)info3).BeginInit();
            panelspot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)info1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)info2).BeginInit();
            SuspendLayout();
            // 
            // toplayer
            // 
            toplayer.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            toplayer.BackColor = Color.FromArgb(241, 202, 74);
            toplayer.Controls.Add(buttonbooknow);
            toplayer.Controls.Add(logo);
            toplayer.Location = new Point(0, 1);
            toplayer.Name = "toplayer";
            toplayer.Size = new Size(1257, 361);
            toplayer.TabIndex = 0;
            // 
            // buttonbooknow
            // 
            buttonbooknow.Anchor = AnchorStyles.Top;
            buttonbooknow.BackColor = Color.FromArgb(255, 26, 60);
            buttonbooknow.FlatAppearance.BorderColor = Color.Black;
            buttonbooknow.FlatAppearance.BorderSize = 2;
            buttonbooknow.FlatStyle = FlatStyle.Flat;
            buttonbooknow.Font = new Font("Kristen ITC", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonbooknow.ForeColor = SystemColors.ButtonHighlight;
            buttonbooknow.Location = new Point(467, 224);
            buttonbooknow.Name = "buttonbooknow";
            buttonbooknow.Size = new Size(303, 117);
            buttonbooknow.TabIndex = 4;
            buttonbooknow.Text = "Book now";
            buttonbooknow.UseVisualStyleBackColor = false;
            buttonbooknow.Click += buttonbooknow_Click;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(495, 11);
            logo.Name = "logo";
            logo.Size = new Size(253, 153);
            logo.SizeMode = PictureBoxSizeMode.AutoSize;
            logo.TabIndex = 0;
            logo.TabStop = false;
            // 
            // infobackground
            // 
            infobackground.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            infobackground.AutoScroll = true;
            infobackground.BackgroundImageLayout = ImageLayout.Zoom;
            infobackground.Controls.Add(infotext3);
            infobackground.Controls.Add(info3);
            infobackground.Controls.Add(panelspot);
            infobackground.Location = new Point(0, 361);
            infobackground.Name = "infobackground";
            infobackground.Size = new Size(1257, 1095);
            infobackground.TabIndex = 3;
            // 
            // infotext3
            // 
            infotext3.Anchor = AnchorStyles.Bottom;
            infotext3.BackColor = Color.FromArgb(0, 229, 255);
            infotext3.BorderStyle = BorderStyle.None;
            infotext3.Font = new Font("Kristen ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infotext3.Location = new Point(77, 834);
            infotext3.Multiline = true;
            infotext3.Name = "infotext3";
            infotext3.ReadOnly = true;
            infotext3.Size = new Size(1016, 147);
            infotext3.TabIndex = 5;
            infotext3.Text = resources.GetString("infotext3.Text");
            // 
            // info3
            // 
            info3.Anchor = AnchorStyles.Bottom;
            info3.BackColor = Color.Transparent;
            info3.Image = (Image)resources.GetObject("info3.Image");
            info3.Location = new Point(9, 766);
            info3.Name = "info3";
            info3.Size = new Size(1248, 329);
            info3.SizeMode = PictureBoxSizeMode.AutoSize;
            info3.TabIndex = 2;
            info3.TabStop = false;
            // 
            // panelspot
            // 
            panelspot.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelspot.BackColor = Color.Transparent;
            panelspot.BackgroundImage = (Image)resources.GetObject("panelspot.BackgroundImage");
            panelspot.BackgroundImageLayout = ImageLayout.Center;
            panelspot.Controls.Add(infotext1);
            panelspot.Controls.Add(infotext2);
            panelspot.Controls.Add(info1);
            panelspot.Controls.Add(info2);
            panelspot.Location = new Point(0, 3);
            panelspot.Name = "panelspot";
            panelspot.Size = new Size(1257, 764);
            panelspot.TabIndex = 7;
            // 
            // infotext1
            // 
            infotext1.Anchor = AnchorStyles.Left;
            infotext1.BackColor = Color.FromArgb(0, 229, 255);
            infotext1.BorderStyle = BorderStyle.None;
            infotext1.Font = new Font("Kristen ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infotext1.Location = new Point(157, 151);
            infotext1.Multiline = true;
            infotext1.Name = "infotext1";
            infotext1.ReadOnly = true;
            infotext1.Size = new Size(290, 155);
            infotext1.TabIndex = 3;
            infotext1.Text = resources.GetString("infotext1.Text");
            // 
            // infotext2
            // 
            infotext2.Anchor = AnchorStyles.Right;
            infotext2.BackColor = Color.FromArgb(0, 229, 255);
            infotext2.BorderStyle = BorderStyle.None;
            infotext2.Font = new Font("Kristen ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            infotext2.Location = new Point(704, 315);
            infotext2.Multiline = true;
            infotext2.Name = "infotext2";
            infotext2.ReadOnly = true;
            infotext2.Size = new Size(371, 229);
            infotext2.TabIndex = 4;
            infotext2.Text = resources.GetString("infotext2.Text");
            // 
            // info1
            // 
            info1.Anchor = AnchorStyles.Left;
            info1.BackColor = Color.Transparent;
            info1.BackgroundImage = (Image)resources.GetObject("info1.BackgroundImage");
            info1.Location = new Point(110, 60);
            info1.Name = "info1";
            info1.Size = new Size(367, 365);
            info1.SizeMode = PictureBoxSizeMode.AutoSize;
            info1.TabIndex = 0;
            info1.TabStop = false;
            // 
            // info2
            // 
            info2.Anchor = AnchorStyles.Right;
            info2.BackColor = Color.Transparent;
            info2.Image = (Image)resources.GetObject("info2.Image");
            info2.Location = new Point(666, 202);
            info2.Name = "info2";
            info2.Size = new Size(461, 461);
            info2.SizeMode = PictureBoxSizeMode.AutoSize;
            info2.TabIndex = 1;
            info2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1273, 670);
            Controls.Add(infobackground);
            Controls.Add(toplayer);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            toplayer.ResumeLayout(false);
            toplayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            infobackground.ResumeLayout(false);
            infobackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)info3).EndInit();
            panelspot.ResumeLayout(false);
            panelspot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)info1).EndInit();
            ((System.ComponentModel.ISupportInitialize)info2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel toplayer;
        private PictureBox logo;
        private Panel infobackground;
        private PictureBox info1;
        private PictureBox info2;
        private PictureBox info3;
        private TextBox infotext1;
        private TextBox infotext2;
        private TextBox infotext3;
        private Button buttonbooknow;
        private Panel panelspot;
    }
}
