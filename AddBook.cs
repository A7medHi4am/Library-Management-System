using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Project
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void AddBook_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "" && txtAuthor.Text != "" && comboGenre.Text != "" && txtIsbn.Text != "" && txtQuantity.Text != "" && txtPrice.Text != "" )
            {
                string Title = txtTitle.Text;
                string Author = txtAuthor.Text;
                string Genre = comboGenre.Text;
                int ISBN = int.Parse(txtIsbn.Text);
                int TotalCopies = int.Parse(txtQuantity.Text);
                int Price = int.Parse(txtPrice.Text);

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Data Source=(localdb)\\Local;Initial Catalog=library;Integrated Security=True;Encrypt=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "Insert into Books (Title,Author,Genre,ISBN,TotalCopies,Price) values ('" + Title + "','" + Author + "','" + Genre + "','" + ISBN + "','" + TotalCopies + "','" + Price + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                txtTitle.Text = "";
                txtAuthor.Text = "";
                comboGenre.Text = "";
                txtIsbn.Text = "";
                txtQuantity.Text = "";
                txtPrice.Text = "";
                MessageBox.Show("Book added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Empty Field not allowed","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);    
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
