namespace Project
{
    partial class ViewBorrowings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBorrowings));
            dataGridView3 = new DataGridView();
            label1 = new Label();
            txtBorrowingID = new TextBox();
            btnClear = new Button();
            label2 = new Label();
            txtUserID2 = new TextBox();
            txtBookID2 = new TextBox();
            label3 = new Label();
            dateBorrow2 = new DateTimePicker();
            dateReturn2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            btnDelete = new Button();
            btnUpdate = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView3
            // 
            dataGridView3.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView3.BorderStyle = BorderStyle.None;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(105, 79);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(598, 193);
            dataGridView3.TabIndex = 5;
            dataGridView3.CellClick += dataGridView3_CellClick;
            dataGridView3.CellContentClick += dataGridView3_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(240, 36);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 6;
            label1.Text = "Borrowings ID";
            // 
            // txtBorrowingID
            // 
            txtBorrowingID.Location = new Point(336, 33);
            txtBorrowingID.Name = "txtBorrowingID";
            txtBorrowingID.Size = new Size(188, 23);
            txtBorrowingID.TabIndex = 9;
            txtBorrowingID.TextChanged += txtUserID_TextChanged;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(556, 33);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(74, 17);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 11;
            label2.Text = "User ID";
            // 
            // txtUserID2
            // 
            txtUserID2.Location = new Point(129, 14);
            txtUserID2.Name = "txtUserID2";
            txtUserID2.Size = new Size(161, 23);
            txtUserID2.TabIndex = 12;
            txtUserID2.TextChanged += txtUserID2_TextChanged;
            // 
            // txtBookID2
            // 
            txtBookID2.Location = new Point(382, 14);
            txtBookID2.Name = "txtBookID2";
            txtBookID2.Size = new Size(161, 23);
            txtBookID2.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(321, 17);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 14;
            label3.Text = "Book ID";
            // 
            // dateBorrow2
            // 
            dateBorrow2.Location = new Point(129, 49);
            dateBorrow2.Name = "dateBorrow2";
            dateBorrow2.Size = new Size(161, 23);
            dateBorrow2.TabIndex = 15;
            // 
            // dateReturn2
            // 
            dateReturn2.Location = new Point(383, 47);
            dateReturn2.Name = "dateReturn2";
            dateReturn2.Size = new Size(160, 23);
            dateReturn2.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(51, 53);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 17;
            label4.Text = "Borrow Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(308, 49);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 18;
            label5.Text = "Return Date";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnDelete);
            panel3.Controls.Add(btnUpdate);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(dateReturn2);
            panel3.Controls.Add(dateBorrow2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtBookID2);
            panel3.Controls.Add(txtUserID2);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(31, 284);
            panel3.Name = "panel3";
            panel3.Size = new Size(757, 89);
            panel3.TabIndex = 19;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(580, 53);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 24);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(580, 14);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 24);
            btnUpdate.TabIndex = 20;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // ViewBorrowings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(panel3);
            Controls.Add(btnClear);
            Controls.Add(txtBorrowingID);
            Controls.Add(label1);
            Controls.Add(dataGridView3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewBorrowings";
            Text = "ViewBorrowings";
            Load += ViewBorrowings_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView3;
        private Label label1;
        private TextBox txtBorrowingID;
        private Button btnClear;
        private Label label2;
        private TextBox txtUserID2;
        private TextBox txtBookID2;
        private Label label3;
        private DateTimePicker dateBorrow2;
        private DateTimePicker dateReturn2;
        private Label label4;
        private Label label5;
        private Panel panel3;
        private Button btnUpdate;
        private Button btnDelete;
    }
}