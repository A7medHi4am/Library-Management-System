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
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text != "" && txtLast.Text != "" && txtAddress.Text != "" && txtEmail.Text != "" && txtPhoneNumber.Text != "")
            {
                string FirstName = txtFirst.Text;
                string LastName = txtLast.Text;
                string Address = txtAddress.Text;
                string Email = txtEmail.Text;
                string PhoneNumber = txtPhoneNumber.Text;


                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library;Integrated Security=True;Encrypt=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "Insert into Users (FirstName,LastName,Email,PhoneNumber,Address) values ('" + FirstName + "','" + LastName + "','" + Email + "','" + PhoneNumber + "','" + Address + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                txtFirst.Text = "";
                txtLast.Text = "";
                txtAddress.Text = "";
                txtEmail.Text = "";
                txtPhoneNumber.Text = "";
                MessageBox.Show("Member added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empty Field not allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
