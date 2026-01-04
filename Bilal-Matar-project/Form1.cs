using Microsoft.Data.SqlClient;
using System.Data;

namespace Bilal_Matar_project
{
    public partial class Form1 : Form
    {
        static string connString = "Data Source=.\\SQLEXPRESS; Initial Catalog=project_dbvs;Integrated Security=True; TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_up_Click(object sender, EventArgs e)
        {

        }
    }
}
