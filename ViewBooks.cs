using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class ViewBooks : Form
    {
        public ViewBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ViewBooks_Load(object sender, EventArgs e)
        {
            panel1.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Books";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int bid;
        int rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel1.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Books where BookID = " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtTitle.Text = ds.Tables[0].Rows[0][1].ToString();
            txtAuthor.Text = ds.Tables[0].Rows[0][2].ToString();
            txtGenre.Text = ds.Tables[0].Rows[0][3].ToString();
            txtISBN.Text = ds.Tables[0].Rows[0][4].ToString();
            txtAvailable.Text = ds.Tables[0].Rows[0][5].ToString();
            txtTotalCopies.Text = ds.Tables[0].Rows[0][6].ToString();
            txtPrice.Text = ds.Tables[0].Rows[0][7].ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";

            // Construct the SQL query
            string query;
            if (!string.IsNullOrWhiteSpace(txtBookName.Text))
            {
                query = "SELECT * FROM Books WHERE Title LIKE @Title";
            }
            else
            {
                query = "SELECT * FROM Books";
            }

            // Create the SqlConnection and SqlCommand objects
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                // Add parameter for the book title (if provided)
                if (!string.IsNullOrWhiteSpace(txtBookName.Text))
                {
                    cmd.Parameters.AddWithValue("@Title", txtBookName.Text + "%");
                }

                // Create SqlDataAdapter and DataSet
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                // Fill the DataSet with data from the database
                da.Fill(ds);

                // Set the DataGridView's DataSource to the DataSet's first table
                dataGridView1.DataSource = ds.Tables[0];
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtBookName.Clear();
            txtISBNsearch.Clear();
            panel1.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Book will be updated, Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string Title = txtTitle.Text;
                string Author = txtAuthor.Text;
                string Genre = txtGenre.Text;
                string ISBN = txtISBN.Text;
                string AvailabeCopies = txtAvailable.Text;
                string TotalCopies = txtTotalCopies.Text;
                int Price = int.Parse(txtPrice.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Books set Title = '" + Title + "',Author = '" + Author + "',Genre ='" + Genre + "',ISBN = '" + ISBN + "',AvailableCopies = '" + AvailabeCopies + "',TotalCopies = '" + TotalCopies + "',Price = '" + Price + "' where BookID = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Book will be deleted, Confirm?", "Confirmation dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Books where BookID = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";

            // Construct the SQL query
            string query;
            if (!string.IsNullOrWhiteSpace(txtISBNsearch.Text))
            {
                query = "SELECT * FROM Books WHERE ISBN LIKE @ISBN";
            }
            else
            {
                query = "SELECT * FROM Books";
            }

            // Create the SqlConnection and SqlCommand objects
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                // Add parameter for the book title (if provided)
                if (!string.IsNullOrWhiteSpace(txtISBNsearch.Text))
                {
                    cmd.Parameters.AddWithValue("@ISBN", txtISBNsearch.Text + "%");
                }

                // Create SqlDataAdapter and DataSet
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                // Fill the DataSet with data from the database
                da.Fill(ds);

                // Set the DataGridView's DataSource to the DataSet's first table
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}
