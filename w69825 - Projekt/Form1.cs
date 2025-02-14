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
            System.Data.DataTable table = new System.Data.DataTable();

            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Imiê", typeof(string));
            table.Columns.Add("Nazwisko", typeof(string));
            table.Columns.Add("Us³uga", typeof(string));

            table.Rows.Add(1, "Jan", "Kowalski", "Strzy¿enie");
            table.Rows.Add(2, "Anna", "Nowak", "Golenie");
            table.Rows.Add(3, "Piotr", "Wiœniewski", "Farbowanie");

            dataGridView1.DataSource = table;
        }
    }
}
