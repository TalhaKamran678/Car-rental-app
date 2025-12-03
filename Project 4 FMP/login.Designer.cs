namespace Project_4_FMP
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            labellogin = new Label();
            labelusername = new Label();
            labelpassword = new Label();
            textBoxusername = new TextBox();
            textBoxpassword = new TextBox();
            buttonlogin = new Button();
            buttontryregister = new Button();
            buttonback = new Button();
            SuspendLayout();
            // 
            // labellogin
            // 
            labellogin.Anchor = AnchorStyles.Top;
            labellogin.AutoSize = true;
            labellogin.BackColor = Color.Transparent;
            labellogin.Font = new Font("Kristen ITC", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labellogin.ForeColor = SystemColors.ButtonHighlight;
            labellogin.Location = new Point(308, 54);
            labellogin.Name = "labellogin";
            labellogin.Size = new Size(212, 88);
            labellogin.TabIndex = 0;
            labellogin.Text = "Login";
            // 
            // labelusername
            // 
            labelusername.Anchor = AnchorStyles.None;
            labelusername.AutoSize = true;
            labelusername.BackColor = Color.Transparent;
            labelusername.Font = new Font("Kristen ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelusername.ForeColor = SystemColors.ButtonHighlight;
            labelusername.Location = new Point(147, 155);
            labelusername.Name = "labelusername";
            labelusername.Size = new Size(122, 29);
            labelusername.TabIndex = 1;
            labelusername.Text = "Username:";
            // 
            // labelpassword
            // 
            labelpassword.Anchor = AnchorStyles.None;
            labelpassword.AutoSize = true;
            labelpassword.BackColor = Color.Transparent;
            labelpassword.Font = new Font("Kristen ITC", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelpassword.ForeColor = Color.White;
            labelpassword.Location = new Point(150, 200);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(119, 29);
            labelpassword.TabIndex = 2;
            labelpassword.Text = "Password:";
            // 
            // textBoxusername
            // 
            textBoxusername.Anchor = AnchorStyles.None;
            textBoxusername.Location = new Point(308, 155);
            textBoxusername.Name = "textBoxusername";
            textBoxusername.Size = new Size(199, 23);
            textBoxusername.TabIndex = 3;
            // 
            // textBoxpassword
            // 
            textBoxpassword.Anchor = AnchorStyles.None;
            textBoxpassword.Location = new Point(308, 200);
            textBoxpassword.Name = "textBoxpassword";
            textBoxpassword.Size = new Size(199, 23);
            textBoxpassword.TabIndex = 4;
            textBoxpassword.UseSystemPasswordChar = true;
            // 
            // buttonlogin
            // 
            buttonlogin.Anchor = AnchorStyles.Bottom;
            buttonlogin.BackColor = Color.Cyan;
            buttonlogin.FlatAppearance.BorderSize = 0;
            buttonlogin.FlatStyle = FlatStyle.Flat;
            buttonlogin.Font = new Font("Kristen ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonlogin.ForeColor = SystemColors.ActiveCaptionText;
            buttonlogin.Location = new Point(356, 255);
            buttonlogin.Name = "buttonlogin";
            buttonlogin.Size = new Size(95, 34);
            buttonlogin.TabIndex = 5;
            buttonlogin.Text = "Login";
            buttonlogin.UseVisualStyleBackColor = false;
            buttonlogin.Click += buttonlogin_Click;
            // 
            // buttontryregister
            // 
            buttontryregister.Anchor = AnchorStyles.Bottom;
            buttontryregister.BackColor = Color.Cyan;
            buttontryregister.FlatAppearance.BorderSize = 0;
            buttontryregister.FlatStyle = FlatStyle.Flat;
            buttontryregister.Font = new Font("Kristen ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttontryregister.Location = new Point(356, 295);
            buttontryregister.Name = "buttontryregister";
            buttontryregister.Size = new Size(95, 35);
            buttontryregister.TabIndex = 6;
            buttontryregister.Text = "Try Register";
            buttontryregister.UseVisualStyleBackColor = false;
            buttontryregister.Click += buttontryregister_Click;
            // 
            // buttonback
            // 
            buttonback.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonback.BackColor = Color.Cyan;
            buttonback.FlatAppearance.BorderSize = 0;
            buttonback.FlatStyle = FlatStyle.Flat;
            buttonback.Font = new Font("Kristen ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonback.Location = new Point(12, 434);
            buttonback.Name = "buttonback";
            buttonback.Size = new Size(95, 37);
            buttonback.TabIndex = 7;
            buttonback.Text = "Back";
            buttonback.UseVisualStyleBackColor = false;
            buttonback.Click += buttonback_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(795, 483);
            Controls.Add(buttonback);
            Controls.Add(buttontryregister);
            Controls.Add(buttonlogin);
            Controls.Add(textBoxpassword);
            Controls.Add(textBoxusername);
            Controls.Add(labelpassword);
            Controls.Add(labelusername);
            Controls.Add(labellogin);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labellogin;
        private Label labelusername;
        private Label labelpassword;
        private TextBox textBoxusername;
        private TextBox textBoxpassword;
        private Button buttonlogin;
        private Button buttontryregister;
        private Button buttonback;
    }
}