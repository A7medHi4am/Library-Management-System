namespace Project
{
    partial class AddBorrowing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddBorrowing));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtUserID = new TextBox();
            txtBookID = new TextBox();
            dateBorrow = new DateTimePicker();
            dateReturn = new DateTimePicker();
            pictureBox1 = new PictureBox();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(105, 134);
            label1.Name = "label1";
            label1.Size = new Size(74, 19);
            label1.TabIndex = 1;
            label1.Text = "User ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(105, 176);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 2;
            label2.Text = "Book ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(64, 215);
            label3.Name = "label3";
            label3.Size = new Size(119, 19);
            label3.TabIndex = 3;
            label3.Text = "Borrow Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Swis721 Blk BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(68, 252);
            label4.Name = "label4";
            label4.Size = new Size(115, 19);
            label4.TabIndex = 4;
            label4.Text = "Return Date";
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(207, 130);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(190, 23);
            txtUserID.TabIndex = 5;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(207, 172);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(190, 23);
            txtBookID.TabIndex = 6;
            // 
            // dateBorrow
            // 
            dateBorrow.Location = new Point(207, 212);
            dateBorrow.Name = "dateBorrow";
            dateBorrow.Size = new Size(190, 23);
            dateBorrow.TabIndex = 7;
            // 
            // dateReturn
            // 
            dateReturn.Location = new Point(207, 248);
            dateReturn.Name = "dateReturn";
            dateReturn.Size = new Size(190, 23);
            dateReturn.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(147, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 62);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = SystemColors.Menu;
            btnAdd.BackgroundImageLayout = ImageLayout.None;
            btnAdd.FlatStyle = FlatStyle.Popup;
            btnAdd.Font = new Font("Lucida Sans Typewriter", 9F, FontStyle.Bold);
            btnAdd.ForeColor = Color.Black;
            btnAdd.Location = new Point(207, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(53, 22);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // AddBorrowing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(489, 411);
            Controls.Add(btnAdd);
            Controls.Add(pictureBox1);
            Controls.Add(dateReturn);
            Controls.Add(dateBorrow);
            Controls.Add(txtBookID);
            Controls.Add(txtUserID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AddBorrowing";
            Text = "AddBorrowing";
            Load += AddBorrowing_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtUserID;
        private TextBox txtBookID;
        private DateTimePicker dateBorrow;
        private DateTimePicker dateReturn;
        private PictureBox pictureBox1;
        private Button btnAdd;
    }
}