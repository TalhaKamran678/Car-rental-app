namespace Project_4_FMP
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            welcomesign = new Label();
            pictureBox1 = new PictureBox();
            enter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // welcomesign
            // 
            welcomesign.Anchor = AnchorStyles.None;
            welcomesign.AutoSize = true;
            welcomesign.BackColor = Color.Transparent;
            welcomesign.Font = new Font("Kristen ITC", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            welcomesign.ForeColor = Color.FromArgb(255, 26, 60);
            welcomesign.Location = new Point(281, 42);
            welcomesign.Name = "welcomesign";
            welcomesign.Size = new Size(317, 176);
            welcomesign.TabIndex = 0;
            welcomesign.Text = "Welcome\r\nTo";
            welcomesign.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(309, 221);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(253, 153);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // enter
            // 
            enter.Anchor = AnchorStyles.None;
            enter.BackColor = Color.FromArgb(0, 229, 255);
            enter.BackgroundImageLayout = ImageLayout.None;
            enter.FlatAppearance.BorderColor = Color.FromArgb(255, 26, 60);
            enter.FlatAppearance.BorderSize = 2;
            enter.FlatStyle = FlatStyle.Flat;
            enter.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            enter.Location = new Point(370, 410);
            enter.Name = "enter";
            enter.Size = new Size(120, 43);
            enter.TabIndex = 2;
            enter.Text = "Enter";
            enter.UseVisualStyleBackColor = false;
            enter.Click += enter_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 202, 74);
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(894, 549);
            Controls.Add(enter);
            Controls.Add(pictureBox1);
            Controls.Add(welcomesign);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomesign;
        private PictureBox pictureBox1;
        private Button enter;
    }
}