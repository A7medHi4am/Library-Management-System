namespace Project
{
    public partial class Form1 : Form
    {
        private Image backgroundImage;
        private readonly string username;

        public Form1(string username)
        {
            InitializeComponent();
            this.username = username;
            label3.Text = "" + username + "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addNewMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddMember absd = new AddMember();
            absd.Show();
        }

        private void viewMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewMembers abid = new ViewMembers();
            abid.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBook abs = new AddBook();
            abs.Show();
        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewBooks vb = new ViewBooks();
            vb.Show();
        }

        private void booksToolStripMenuItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ViewBorrowings vbb = new ViewBorrowings();
            vbb.Show();
        }

        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            AddBorrowing abbjk = new AddBorrowing();
            abbjk.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
