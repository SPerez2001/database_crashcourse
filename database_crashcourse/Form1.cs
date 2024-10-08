using System.Data;
using System.Data.SqlClient;

namespace database_crashcourse
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;AttachDbFilename=""|DataDirectory|\prod.mdf"";Integrated Security=True;Connect Timeout=30");
        DataTable dt;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            
            con.Close();
        }

    }
}
