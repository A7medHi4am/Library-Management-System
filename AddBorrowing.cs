using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddBorrowing : Form
    {
        public AddBorrowing()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtUserID.Text != "" && txtBookID.Text != "" && dateBorrow.Text != "" && dateReturn.Text != "")
            {
                int UserID = int.Parse(txtUserID.Text);
                int BookID = int.Parse(txtBookID.Text);
                DateTime BorrowDate = dateBorrow.Value;
                DateTime ReturnDate = dateReturn.Value;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library;Integrated Security=True;Encrypt=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "Insert into BookBorrowings (UserID,BookID,BorrowDate,ReturnDate) values ('" + UserID + "','" + BookID + "','" + BorrowDate + "','" + ReturnDate + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                txtUserID.Text = "";
                txtBookID.Text = "";
                dateBorrow.Value = DateTime.Now;
                dateReturn.Value = DateTime.Now;
                MessageBox.Show("Book Borrowed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empty Field not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void AddBorrowing_Load(object sender, EventArgs e)
        {

        }
    }
}
