namespace Project
{
    partial class ViewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBooks));
            label1 = new Label();
            txtBookName = new TextBox();
            btnRefresh = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtTitle = new TextBox();
            txtAvailable = new TextBox();
            txtISBN = new TextBox();
            txtGenre = new TextBox();
            txtAuthor = new TextBox();
            txtTotalCopies = new TextBox();
            txtPrice = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            txtISBNsearch = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 0;
            label1.Text = "Book Name";
            label1.Click += label1_Click;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(110, 24);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(188, 23);
            txtBookName.TabIndex = 1;
            txtBookName.TextChanged += textBox1_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(645, 29);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "Clear";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ActiveCaptionText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(7, 61);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(781, 193);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(13, 10);
            label2.Name = "label2";
            label2.Size = new Size(69, 15);
            label2.TabIndex = 4;
            label2.Text = "Book Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(26, 87);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 5;
            label3.Text = "Genre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(26, 52);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 6;
            label4.Text = "Author";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(26, 127);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 7;
            label5.Text = "ISBN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(357, 10);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 8;
            label6.Text = "Available";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(341, 55);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 9;
            label7.Text = "Total Copies";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(357, 90);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 10;
            label8.Text = "Price";
            label8.Click += label8_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(88, 7);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(217, 23);
            txtTitle.TabIndex = 11;
            // 
            // txtAvailable
            // 
            txtAvailable.Location = new Point(418, 7);
            txtAvailable.Name = "txtAvailable";
            txtAvailable.Size = new Size(217, 23);
            txtAvailable.TabIndex = 12;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(88, 124);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(217, 23);
            txtISBN.TabIndex = 13;
            // 
            // txtGenre
            // 
            txtGenre.Location = new Point(88, 87);
            txtGenre.Name = "txtGenre";
            txtGenre.Size = new Size(217, 23);
            txtGenre.TabIndex = 14;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(88, 52);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(217, 23);
            txtAuthor.TabIndex = 15;
            // 
            // txtTotalCopies
            // 
            txtTotalCopies.Location = new Point(418, 49);
            txtTotalCopies.Name = "txtTotalCopies";
            txtTotalCopies.Size = new Size(217, 23);
            txtTotalCopies.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(418, 84);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(217, 23);
            txtPrice.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(412, 130);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(92, 24);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(525, 130);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(92, 24);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Black;
            btnClose.BackgroundImageLayout = ImageLayout.None;
            btnClose.FlatStyle = FlatStyle.Popup;
            btnClose.Image = (Image)resources.GetObject("btnClose.Image");
            btnClose.Location = new Point(756, 10);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 37);
            btnClose.TabIndex = 21;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(txtPrice);
            panel1.Controls.Add(txtTotalCopies);
            panel1.Controls.Add(txtAuthor);
            panel1.Controls.Add(txtGenre);
            panel1.Controls.Add(txtISBN);
            panel1.Controls.Add(txtAvailable);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(22, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(730, 170);
            panel1.TabIndex = 22;
            // 
            // txtISBNsearch
            // 
            txtISBNsearch.Location = new Point(391, 24);
            txtISBNsearch.Name = "txtISBNsearch";
            txtISBNsearch.Size = new Size(188, 23);
            txtISBNsearch.TabIndex = 23;
            txtISBNsearch.TextChanged += textBox1_TextChanged_1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(341, 29);
            label9.Name = "label9";
            label9.Size = new Size(32, 15);
            label9.TabIndex = 24;
            label9.Text = "ISBN";
            // 
            // ViewBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(label9);
            Controls.Add(txtISBNsearch);
            Controls.Add(panel1);
            Controls.Add(btnClose);
            Controls.Add(dataGridView1);
            Controls.Add(btnRefresh);
            Controls.Add(txtBookName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ViewBooks";
            Text = "ViewBooks";
            Load += ViewBooks_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBookName;
        private Button btnRefresh;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtTitle;
        private TextBox txtAvailable;
        private TextBox txtISBN;
        private TextBox txtGenre;
        private TextBox txtAuthor;
        private TextBox txtTotalCopies;
        private TextBox txtPrice;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private Panel panel1;
        private TextBox txtISBNsearch;
        private Label label9;
    }
}