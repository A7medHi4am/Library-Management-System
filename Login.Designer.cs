namespace Project
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            txtUsername = new TextBox();
            pictureBox3 = new PictureBox();
            txtPassword = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button1 = new Button();
            button2 = new Button();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(71, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 65);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(50, 173);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 55);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.MenuText;
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Swis721 BlkCn BT", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = SystemColors.Menu;
            txtUsername.HideSelection = false;
            txtUsername.Location = new Point(106, 190);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(166, 15);
            txtUsername.TabIndex = 2;
            txtUsername.TabStop = false;
            txtUsername.Text = "Username";
            txtUsername.TextChanged += txtUsername_TextChanged;
            txtUsername.MouseEnter += txtUsername_MouseEnter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(50, 253);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 52);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.MenuText;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Swis721 BlkCn BT", 9F);
            txtPassword.ForeColor = SystemColors.Menu;
            txtPassword.Location = new Point(106, 266);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(166, 15);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Password";
            txtPassword.MouseClick += txtPassword_MouseClick;
            txtPassword.TextChanged += textBox2_TextChanged;
            txtPassword.MouseEnter += txtPassword_MouseEnter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(106, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(164, 3);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(106, 295);
            panel2.Name = "panel2";
            panel2.Size = new Size(164, 3);
            panel2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Swis721 BlkCn BT", 16F);
            button1.Location = new Point(55, 318);
            button1.Name = "button1";
            button1.Size = new Size(216, 38);
            button1.TabIndex = 7;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = (Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Swis721 BlkCn BT", 16F);
            button2.ForeColor = Color.Aqua;
            button2.Location = new Point(55, 362);
            button2.Name = "button2";
            button2.Size = new Size(216, 38);
            button2.TabIndex = 8;
            button2.Text = "Sign up";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(308, 13);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 37);
            btnClose.TabIndex = 9;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += button3_Click;
            // 
            // Login
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(350, 500);
            Controls.Add(btnClose);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(txtPassword);
            Controls.Add(pictureBox3);
            Controls.Add(txtUsername);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            Text = "Login";
            MouseClick += Login_MouseClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox txtUsername;
        private PictureBox pictureBox3;
        private TextBox txtPassword;
        private Panel panel1;
        private Panel panel2;
        private Button button1;
        private Button button2;
        private Button btnClose;
    }
}