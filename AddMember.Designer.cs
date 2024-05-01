namespace Project
{
    partial class AddMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMember));
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFirst = new TextBox();
            txtEmail = new TextBox();
            txtPhoneNumber = new TextBox();
            txtLast = new TextBox();
            txtAddress = new TextBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(170, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 62);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(461, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 37);
            btnClose.TabIndex = 16;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 12F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(52, 143);
            label1.Name = "label1";
            label1.Size = new Size(99, 19);
            label1.TabIndex = 17;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 12F);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(61, 220);
            label2.Name = "label2";
            label2.Size = new Size(57, 19);
            label2.TabIndex = 18;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 Blk BT", 12F);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(52, 179);
            label3.Name = "label3";
            label3.Size = new Size(98, 19);
            label3.TabIndex = 19;
            label3.Text = "LastName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 Blk BT", 12F);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(52, 302);
            label4.Name = "label4";
            label4.Size = new Size(81, 19);
            label4.TabIndex = 20;
            label4.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 Blk BT", 12F);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(61, 264);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 21;
            label5.Text = "Phone";
            label5.Click += label5_Click;
            // 
            // txtFirst
            // 
            txtFirst.Location = new Point(170, 143);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(256, 23);
            txtFirst.TabIndex = 22;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(170, 220);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(256, 23);
            txtEmail.TabIndex = 23;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(170, 264);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(256, 23);
            txtPhoneNumber.TabIndex = 24;
            txtPhoneNumber.TextChanged += txtPhone_TextChanged;
            // 
            // txtLast
            // 
            txtLast.Location = new Point(170, 179);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(256, 23);
            txtLast.TabIndex = 25;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(170, 302);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(256, 23);
            txtAddress.TabIndex = 26;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Menu;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(216, 352);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(53, 22);
            btnAdd.TabIndex = 27;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(505, 450);
            Controls.Add(btnAdd);
            Controls.Add(txtAddress);
            Controls.Add(txtLast);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmail);
            Controls.Add(txtFirst);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddMember";
            Text = "AddMember";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnClose;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFirst;
        private TextBox txtEmail;
        private TextBox txtPhoneNumber;
        private TextBox txtLast;
        private TextBox txtAddress;
        private Button btnAdd;
    }
}