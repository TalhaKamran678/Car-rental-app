namespace Project_4_FMP
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            labelregister = new Label();
            labelusername = new Label();
            labelemail = new Label();
            labelpassword = new Label();
            labelconfirm = new Label();
            textboxusername = new TextBox();
            textboxemail = new TextBox();
            textboxpassword = new TextBox();
            textboxconfirm = new TextBox();
            buttonregister = new Button();
            buttontrylogin = new Button();
            buttonback2 = new Button();
            SuspendLayout();
            // 
            // labelregister
            // 
            labelregister.Anchor = AnchorStyles.Top;
            labelregister.AutoSize = true;
            labelregister.BackColor = Color.Transparent;
            labelregister.Font = new Font("Kristen ITC", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelregister.ForeColor = SystemColors.ButtonHighlight;
            labelregister.Location = new Point(245, 37);
            labelregister.Name = "labelregister";
            labelregister.Size = new Size(296, 88);
            labelregister.TabIndex = 0;
            labelregister.Text = "Register";
            // 
            // labelusername
            // 
            labelusername.Anchor = AnchorStyles.None;
            labelusername.AutoSize = true;
            labelusername.BackColor = Color.Transparent;
            labelusername.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelusername.ForeColor = Color.White;
            labelusername.Location = new Point(202, 144);
            labelusername.Name = "labelusername";
            labelusername.Size = new Size(93, 23);
            labelusername.TabIndex = 1;
            labelusername.Text = "Username:";
            // 
            // labelemail
            // 
            labelemail.Anchor = AnchorStyles.None;
            labelemail.AutoSize = true;
            labelemail.BackColor = Color.Transparent;
            labelemail.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelemail.ForeColor = Color.White;
            labelemail.Location = new Point(202, 178);
            labelemail.Name = "labelemail";
            labelemail.Size = new Size(56, 23);
            labelemail.TabIndex = 2;
            labelemail.Text = "Email:";
            // 
            // labelpassword
            // 
            labelpassword.Anchor = AnchorStyles.None;
            labelpassword.AutoSize = true;
            labelpassword.BackColor = Color.Transparent;
            labelpassword.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelpassword.ForeColor = Color.White;
            labelpassword.Location = new Point(202, 215);
            labelpassword.Name = "labelpassword";
            labelpassword.Size = new Size(89, 23);
            labelpassword.TabIndex = 3;
            labelpassword.Text = "Password:";
            // 
            // labelconfirm
            // 
            labelconfirm.Anchor = AnchorStyles.None;
            labelconfirm.AutoSize = true;
            labelconfirm.BackColor = Color.Transparent;
            labelconfirm.Font = new Font("Kristen ITC", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelconfirm.ForeColor = Color.White;
            labelconfirm.Location = new Point(202, 253);
            labelconfirm.Name = "labelconfirm";
            labelconfirm.Size = new Size(159, 23);
            labelconfirm.TabIndex = 4;
            labelconfirm.Text = "Confirm Password:";
            // 
            // textboxusername
            // 
            textboxusername.Anchor = AnchorStyles.None;
            textboxusername.Location = new Point(384, 144);
            textboxusername.Name = "textboxusername";
            textboxusername.Size = new Size(170, 23);
            textboxusername.TabIndex = 5;
            // 
            // textboxemail
            // 
            textboxemail.Anchor = AnchorStyles.None;
            textboxemail.Location = new Point(384, 178);
            textboxemail.Name = "textboxemail";
            textboxemail.Size = new Size(170, 23);
            textboxemail.TabIndex = 6;
            // 
            // textboxpassword
            // 
            textboxpassword.Anchor = AnchorStyles.None;
            textboxpassword.Location = new Point(384, 215);
            textboxpassword.Name = "textboxpassword";
            textboxpassword.Size = new Size(170, 23);
            textboxpassword.TabIndex = 7;
            textboxpassword.UseSystemPasswordChar = true;
            // 
            // textboxconfirm
            // 
            textboxconfirm.Anchor = AnchorStyles.None;
            textboxconfirm.Location = new Point(384, 253);
            textboxconfirm.Name = "textboxconfirm";
            textboxconfirm.Size = new Size(170, 23);
            textboxconfirm.TabIndex = 8;
            textboxconfirm.UseSystemPasswordChar = true;
            // 
            // buttonregister
            // 
            buttonregister.Anchor = AnchorStyles.Bottom;
            buttonregister.BackColor = Color.Cyan;
            buttonregister.FlatAppearance.BorderSize = 0;
            buttonregister.FlatStyle = FlatStyle.Flat;
            buttonregister.Font = new Font("Kristen ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonregister.ForeColor = SystemColors.ActiveCaptionText;
            buttonregister.Location = new Point(330, 294);
            buttonregister.Name = "buttonregister";
            buttonregister.Size = new Size(95, 34);
            buttonregister.TabIndex = 9;
            buttonregister.Text = "Register";
            buttonregister.UseVisualStyleBackColor = false;
            buttonregister.Click += buttonregister_Click;
            // 
            // buttontrylogin
            // 
            buttontrylogin.Anchor = AnchorStyles.Bottom;
            buttontrylogin.BackColor = Color.Cyan;
            buttontrylogin.FlatAppearance.BorderSize = 0;
            buttontrylogin.FlatStyle = FlatStyle.Flat;
            buttontrylogin.Font = new Font("Kristen ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttontrylogin.ForeColor = SystemColors.ActiveCaptionText;
            buttontrylogin.Location = new Point(301, 334);
            buttontrylogin.Name = "buttontrylogin";
            buttontrylogin.Size = new Size(149, 59);
            buttontrylogin.TabIndex = 10;
            buttontrylogin.Text = "Already have an account? Try Login";
            buttontrylogin.UseVisualStyleBackColor = false;
            buttontrylogin.Click += buttontrylogin_Click;
            // 
            // buttonback2
            // 
            buttonback2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonback2.BackColor = Color.Cyan;
            buttonback2.FlatAppearance.BorderSize = 0;
            buttonback2.FlatStyle = FlatStyle.Flat;
            buttonback2.Font = new Font("Kristen ITC", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonback2.ForeColor = SystemColors.ActiveCaptionText;
            buttonback2.Location = new Point(12, 433);
            buttonback2.Name = "buttonback2";
            buttonback2.Size = new Size(95, 34);
            buttonback2.TabIndex = 11;
            buttonback2.Text = "Back";
            buttonback2.UseVisualStyleBackColor = false;
            buttonback2.Click += buttonback2_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(779, 474);
            Controls.Add(buttonback2);
            Controls.Add(buttontrylogin);
            Controls.Add(buttonregister);
            Controls.Add(textboxconfirm);
            Controls.Add(textboxpassword);
            Controls.Add(textboxemail);
            Controls.Add(textboxusername);
            Controls.Add(labelconfirm);
            Controls.Add(labelpassword);
            Controls.Add(labelemail);
            Controls.Add(labelusername);
            Controls.Add(labelregister);
            DoubleBuffered = true;
            Name = "register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "register";
            Load += register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelregister;
        private Label labelusername;
        private Label labelemail;
        private Label labelpassword;
        private Label labelconfirm;
        private TextBox textboxusername;
        private TextBox textboxemail;
        private TextBox textboxpassword;
        private TextBox textboxconfirm;
        private Button buttonregister;
        private Button buttontrylogin;
        private Button buttonback2;
    }
}