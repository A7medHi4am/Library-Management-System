namespace Project
{
    partial class ViewMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewMembers));
            dataGridView2 = new DataGridView();
            label1 = new Label();
            btnClear = new Button();
            txtUserID = new TextBox();
            panel2 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(32, 51);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(691, 193);
            dataGridView2.TabIndex = 4;
            dataGridView2.CellClick += dataGridView2_CellClick;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(208, 25);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 5;
            label1.Text = "Member ID";
            label1.Click += label1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(523, 21);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(311, 22);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(188, 23);
            txtUserID.TabIndex = 8;
            txtUserID.TextChanged += txtBookName_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnDelete);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(txtAddress);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(txtLastName);
            panel2.Controls.Add(txtFirstName);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(9, 242);
            panel2.Name = "panel2";
            panel2.Size = new Size(763, 157);
            panel2.TabIndex = 9;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(521, 102);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 24);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(424, 102);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 24);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(149, 97);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(189, 23);
            txtAddress.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(424, 54);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(189, 23);
            txtPhone.TabIndex = 13;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 54);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(189, 23);
            txtEmail.TabIndex = 12;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(424, 13);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(189, 23);
            txtLastName.TabIndex = 11;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(149, 13);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(189, 23);
            txtFirstName.TabIndex = 10;
            txtFirstName.TextChanged += textBox1_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(79, 97);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 9;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(357, 57);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 8;
            label5.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(79, 57);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(344, 18);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(79, 16);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 5;
            label2.Text = "First Name";
            label2.Click += label2_Click;
            // 
            // ViewMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(784, 411);
            Controls.Add(panel2);
            Controls.Add(txtUserID);
            Controls.Add(btnClear);
            Controls.Add(label1);
            Controls.Add(dataGridView2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewMembers";
            Text = "ViewMembers";
            Load += ViewMembers_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView2;
        private Label label1;
        private Button btnClear;
        private TextBox txtUserID;
        private Panel panel2;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnUpdate;
        private Button btnDelete;
    }
}