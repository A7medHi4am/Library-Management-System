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
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ViewMembers_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Users";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView2.DataSource = ds.Tables[0];
        }
        int bid;
        int rowid;
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString != null)
            {
                bid = int.Parse(dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from Users where UserID = " + bid + "";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            rowid = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtFirstName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtLastName.Text = ds.Tables[0].Rows[0][2].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][3].ToString();
            txtPhone.Text = ds.Tables[0].Rows[0][4].ToString();
            txtAddress.Text = ds.Tables[0].Rows[0][5].ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("User will be updated, Confirm?", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string FirstName = txtFirstName.Text;
                string LastName = txtLastName.Text;
                string Email = txtEmail.Text;
                string PhoneNumber = txtPhone.Text;
                string Address = txtAddress.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "update Users set FirstName = '" + FirstName + "',LastName = '" + LastName + "',Email ='" + Email + "',PhoneNumber = '" + PhoneNumber + "',Address = '" + Address + "' where UserID = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("User will be deleted, Confirm?", "Confirmation dialog", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "delete from Users where UserID = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
            }
        }

        private void txtBookName_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Data Source=(localdb)\\Local;Initial Catalog=library";

            // Construct the SQL query
            string query;
            if (!string.IsNullOrWhiteSpace(txtUserID.Text))
            {
                query = "SELECT * FROM Users WHERE UserID LIKE @UserID";
            }
            else
            {
                query = "SELECT * FROM Users";
            }

            // Create the SqlConnection and SqlCommand objects
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, con);

                // Add parameter for the book title (if provided)
                if (!string.IsNullOrWhiteSpace(txtUserID.Text))
                {
                    cmd.Parameters.AddWithValue("@UserID", txtUserID.Text + "%");
                }

                // Create SqlDataAdapter and DataSet
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();

                // Fill the DataSet with data from the database
                da.Fill(ds);

                // Set the DataGridView's DataSource to the DataSet's first table
                dataGridView2.DataSource = ds.Tables[0];
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUserID.Clear();
            panel2.Visible = false;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
