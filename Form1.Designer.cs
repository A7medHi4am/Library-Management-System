namespace Project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            booksToolStripMenuItem = new ToolStripMenuItem();
            addNewBookToolStripMenuItem = new ToolStripMenuItem();
            viewBooksToolStripMenuItem = new ToolStripMenuItem();
            membersToolStripMenuItem = new ToolStripMenuItem();
            addNewMemberToolStripMenuItem = new ToolStripMenuItem();
            viewMembersToolStripMenuItem = new ToolStripMenuItem();
            issueBooksToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            folderBrowserDialog1 = new FolderBrowserDialog();
            panel2 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            timer2 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            pictureBox3 = new PictureBox();
            contextMenuStrip1.SuspendLayout();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2 });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(180, 22);
            toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Items.AddRange(new ToolStripItem[] { booksToolStripMenuItem, membersToolStripMenuItem, issueBooksToolStripMenuItem });
            menuStrip1.Location = new Point(303, 5);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(194, 58);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.BackColor = Color.Transparent;
            booksToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            booksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewBookToolStripMenuItem, viewBooksToolStripMenuItem });
            booksToolStripMenuItem.ForeColor = Color.Transparent;
            booksToolStripMenuItem.Image = (Image)resources.GetObject("booksToolStripMenuItem.Image");
            booksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.RightToLeftAutoMirrorImage = true;
            booksToolStripMenuItem.Size = new Size(62, 54);
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            booksToolStripMenuItem.Paint += booksToolStripMenuItem_Paint;
            // 
            // addNewBookToolStripMenuItem
            // 
            addNewBookToolStripMenuItem.BackColor = Color.Transparent;
            addNewBookToolStripMenuItem.Image = (Image)resources.GetObject("addNewBookToolStripMenuItem.Image");
            addNewBookToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            addNewBookToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewBookToolStripMenuItem.Name = "addNewBookToolStripMenuItem";
            addNewBookToolStripMenuItem.Size = new Size(214, 56);
            addNewBookToolStripMenuItem.Text = "Add new book";
            addNewBookToolStripMenuItem.Click += addNewBookToolStripMenuItem_Click;
            // 
            // viewBooksToolStripMenuItem
            // 
            viewBooksToolStripMenuItem.Image = (Image)resources.GetObject("viewBooksToolStripMenuItem.Image");
            viewBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewBooksToolStripMenuItem.Name = "viewBooksToolStripMenuItem";
            viewBooksToolStripMenuItem.Size = new Size(214, 56);
            viewBooksToolStripMenuItem.Text = "View books";
            viewBooksToolStripMenuItem.Click += viewBooksToolStripMenuItem_Click;
            // 
            // membersToolStripMenuItem
            // 
            membersToolStripMenuItem.BackgroundImageLayout = ImageLayout.None;
            membersToolStripMenuItem.DisplayStyle = ToolStripItemDisplayStyle.Image;
            membersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewMemberToolStripMenuItem, viewMembersToolStripMenuItem });
            membersToolStripMenuItem.ForeColor = SystemColors.ButtonFace;
            membersToolStripMenuItem.Image = (Image)resources.GetObject("membersToolStripMenuItem.Image");
            membersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            membersToolStripMenuItem.Size = new Size(62, 54);
            membersToolStripMenuItem.Click += membersToolStripMenuItem_Click;
            // 
            // addNewMemberToolStripMenuItem
            // 
            addNewMemberToolStripMenuItem.Image = (Image)resources.GetObject("addNewMemberToolStripMenuItem.Image");
            addNewMemberToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            addNewMemberToolStripMenuItem.Name = "addNewMemberToolStripMenuItem";
            addNewMemberToolStripMenuItem.Size = new Size(205, 56);
            addNewMemberToolStripMenuItem.Text = "Add New Member";
            addNewMemberToolStripMenuItem.Click += addNewMemberToolStripMenuItem_Click;
            // 
            // viewMembersToolStripMenuItem
            // 
            viewMembersToolStripMenuItem.Image = (Image)resources.GetObject("viewMembersToolStripMenuItem.Image");
            viewMembersToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            viewMembersToolStripMenuItem.Name = "viewMembersToolStripMenuItem";
            viewMembersToolStripMenuItem.Size = new Size(205, 56);
            viewMembersToolStripMenuItem.Text = "View Members";
            viewMembersToolStripMenuItem.Click += viewMembersToolStripMenuItem_Click;
            // 
            // issueBooksToolStripMenuItem
            // 
            issueBooksToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4 });
            issueBooksToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            issueBooksToolStripMenuItem.Image = (Image)resources.GetObject("issueBooksToolStripMenuItem.Image");
            issueBooksToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            issueBooksToolStripMenuItem.Name = "issueBooksToolStripMenuItem";
            issueBooksToolStripMenuItem.Size = new Size(62, 54);
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Image = (Image)resources.GetObject("toolStripMenuItem3.Image");
            toolStripMenuItem3.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(196, 56);
            toolStripMenuItem3.Text = "Add Borrowing";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click_1;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Image = (Image)resources.GetObject("toolStripMenuItem4.Image");
            toolStripMenuItem4.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(196, 56);
            toolStripMenuItem4.Text = "View Borrowings";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(button1);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(menuStrip1);
            panel2.Location = new Point(1, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 64);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(668, 5);
            button1.Name = "button1";
            button1.Size = new Size(85, 56);
            button1.TabIndex = 7;
            button1.Text = "Exit";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // panel3
            // 
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.Location = new Point(0, 5);
            panel3.Name = "panel3";
            panel3.Size = new Size(198, 59);
            panel3.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("SuperFrench", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label3.Location = new Point(35, 8);
            label3.Name = "label3";
            label3.Size = new Size(42, 13);
            label3.TabIndex = 10;
            label3.Text = "label3";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.Location = new Point(4, -3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(801, 86);
            Controls.Add(pictureBox3);
            Controls.Add(label3);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Load += Form1_Load;
            contextMenuStrip1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem addNewBookToolStripMenuItem;
        private ToolStripMenuItem viewBooksToolStripMenuItem;
        private ToolStripMenuItem membersToolStripMenuItem;
        private ToolStripMenuItem addNewMemberToolStripMenuItem;
        private ToolStripMenuItem viewMembersToolStripMenuItem;
        private ToolStripMenuItem issueBooksToolStripMenuItem;
        private FolderBrowserDialog folderBrowserDialog1;
        private Panel panel2;
        private Panel panel3;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Label label3;
        private PictureBox pictureBox3;
    }
}
