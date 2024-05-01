using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ViewBorrowings : Form
    {
        public ViewBorrowings()
        {
            InitializeComponent();
        }

        private void ViewBorrowings_Load(object sender, EventArgs e)
        {
            panel3.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from BookBorrowings";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView3.DataSource = ds.Tables[0];
        }
        int bid;
        int rowid;
        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView3.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString != null)
            {
                bid = int.Parse(dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel3.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from BookBorrowings where BorrowingID = " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtUserID2.Text = ds.Tables[0].Rows[0][1].ToString();
            txtBookID2.Text = ds.Tables[0].Rows[0][2].ToString();
            dateBorrow2.Value = DateTime.Parse(ds.Tables[0].Rows[0][3].ToString());
            dateReturn2.Value = DateTime.Parse(ds.Tables[0].Rows[0][4].ToString());
        }

        private void txtUserID2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be updated, Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string UserID = txtUserID2.Text;
                string BookID = txtBookID2.Text;
                DateTime BorrowDate = dateBorrow2.Value;
                DateTime ReturnDate = dateReturn2.Value;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update BookBorrowings set UserID = '" + UserID + "',BookID = '" + BookID + "',BorrowDate ='" + BorrowDate + "',ReturnDate = '" + ReturnDate + "' where BorrowingID = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void txtUserID_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";

            // Construct the SQL query
            string query;
            if (!string.IsNullOrWhiteSpace(txtBorrowingID.Text))
            {
                query = "SELECT * FROM BookBorrowings WHERE BorrowingID LIKE @BorrowingID";
            }
            else
            {
                query = "SELECT * FROM BookBorrowings";
            }

            // Create the SqlConnection and SqlCommand objects
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                // Add parameter for the book title (if provided)
                if (!string.IsNullOrWhiteSpace(txtBorrowingID.Text))
                {
                    cmd.Parameters.AddWithValue("@BorrowingID", txtBorrowingID.Text + "%");
                }

                // Create SqlDataAdapter and DataSet
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                // Fill the DataSet with data from the database
                da.Fill(ds);

                // Set the DataGridView's DataSource to the DataSet's first table
                dataGridView3.DataSource = ds.Tables[0];
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Borrowing will be deleted, Confirm?", "Confirmation dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from BookBorrowings where BorrowingID = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBorrowingID.Clear();
            panel3.Visible = false;
        }
    }
}
