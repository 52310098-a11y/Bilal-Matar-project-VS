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

        bool StudentEmailExists(string email)
        {
            bool exists = false;

            string query = "SELECT COUNT(*) FROM Student WHERE Email = @email";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    if (count > 0) 
                        exists = true; 
                }

                reader.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return exists;

        }

        bool TeacherEmailExists(string email)
        {
            bool exists = false;

            string query = "SELECT COUNT(*) FROM Teacher WHERE Email = @email";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@email", email);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int count = reader.GetInt32(0);
                    if (count > 0)
                        exists = true;
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return exists;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if(txt_name.Text.Trim() == "" || txt_regEmail.Text.Trim() == "" || txt_regPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (StudentEmailExists(txt_regEmail.Text.Trim()) || TeacherEmailExists(txt_regEmail.Text.Trim()))
            {
                MessageBox.Show("This email already exists");
                txt_regEmail.Focus();
                return;

            }
        string name = txt_name.Text.Trim();
        string email = txt_regEmail.Text.Trim();
        string password = txt_regPassword.Text.Trim();

            string query = "INSERT INTO Student (Name, Email, PasswordHash) VALUES (@name, @email, @password)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@password", password);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student registered successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            txt_name.Clear();
            txt_regEmail.Clear();
            txt_regPassword.Clear();
        }
    }
}
