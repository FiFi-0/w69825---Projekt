using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace w69825___Projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadDataButton_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDatabase"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM Klient";

                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;

                    MessageBox.Show("Po³¹czenie z baz¹ danych zosta³o nawi¹zane!", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Wyst¹pi³ b³¹d podczas ³¹czenia z baz¹ danych: " + ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
