using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

public class BookViewerForm : Form
{
    private DataGridView dataGridViewBooks;
    private Button buttonLoadBooks;

    private string connectionString = "Connection_String";

    public BookViewerForm()
    {
        InitializeComponents();
    }

    private void InitializeComponents()
    {
      
        this.Text = "Book Viewer";
        this.Size = new System.Drawing.Size(800, 600);

        dataGridViewBooks = new DataGridView();
        dataGridViewBooks.Dock = DockStyle.Fill;
        this.Controls.Add(dataGridViewBooks);

        buttonLoadBooks = new Button();
        buttonLoadBooks.Text = "Load Books";
        buttonLoadBooks.Dock = DockStyle.Bottom;
        buttonLoadBooks.Click += ButtonLoadBooks_Click;
        this.Controls.Add(buttonLoadBooks);
    }

    private void ButtonLoadBooks_Click(object sender, EventArgs e)
    {
  
        LoadBooks();
    }

    private void LoadBooks()
    {
        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Books";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable booksTable = new DataTable();
                adapter.Fill(booksTable);

                dataGridViewBooks.DataSource = booksTable;
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error loading books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new BookViewerForm());
    }
}
