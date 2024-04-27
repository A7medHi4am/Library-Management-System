namespace Project
{
    partial class AddBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBook));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAuthor = new TextBox();
            txtQuantity = new TextBox();
            pictureBox1 = new PictureBox();
            btnClose = new Button();
            txtTitle = new TextBox();
            btnAdd = new Button();
            comboGenre = new ComboBox();
            txtPrice = new TextBox();
            label7 = new Label();
            txtIsbn = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(88, 109);
            label1.Name = "label1";
            label1.Size = new Size(48, 19);
            label1.TabIndex = 0;
            label1.Text = "Title";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(82, 262);
            label2.Name = "label2";
            label2.Size = new Size(83, 19);
            label2.TabIndex = 1;
            label2.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(82, 228);
            label3.Name = "label3";
            label3.Size = new Size(51, 19);
            label3.TabIndex = 2;
            label3.Text = "ISBN";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(82, 192);
            label4.Name = "label4";
            label4.Size = new Size(62, 19);
            label4.TabIndex = 3;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(82, 149);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 4;
            label5.Text = "Author";
            label5.Click += label5_Click;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(203, 145);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(256, 23);
            txtAuthor.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(203, 262);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(256, 23);
            txtQuantity.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(155, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 62);
            pictureBox1.TabIndex = 14;
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
            btnClose.TabIndex = 15;
            btnClose.TabStop = false;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(203, 105);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(256, 23);
            txtTitle.TabIndex = 7;
            txtTitle.TextChanged += textBox1_TextChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Menu;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(224, 362);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(53, 22);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += button1_Click;
            // 
            // comboGenre
            // 
            comboGenre.FormattingEnabled = true;
            comboGenre.Items.AddRange(new object[] { "Action", "Adventure", "Fiction" });
            comboGenre.Location = new Point(203, 188);
            comboGenre.Name = "comboGenre";
            comboGenre.Size = new Size(256, 23);
            comboGenre.TabIndex = 16;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(203, 295);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(256, 23);
            txtPrice.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Swis721 Blk BT", 12F);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(88, 299);
            label7.Name = "label7";
            label7.Size = new Size(54, 19);
            label7.TabIndex = 18;
            label7.Text = "Price";
            label7.Click += label7_Click;
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(203, 224);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(256, 23);
            txtIsbn.TabIndex = 19;
            // 
            // AddBook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(505, 450);
            Controls.Add(txtIsbn);
            Controls.Add(label7);
            Controls.Add(txtPrice);
            Controls.Add(comboGenre);
            Controls.Add(btnClose);
            Controls.Add(pictureBox1);
            Controls.Add(btnAdd);
            Controls.Add(txtQuantity);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddBook";
            Load += AddBook_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtAuthor;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox txtQuantity;
        private PictureBox pictureBox1;
        private Button btnClose;
        private TextBox txtTitle;
        private Button btnAdd;
        private ComboBox comboGenre;
        private TextBox txtPrice;
        private Label label7;
        private TextBox txtIsbn;
    }
}