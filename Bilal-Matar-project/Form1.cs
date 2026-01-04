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
            string email = txt_logEmail.Text.Trim();
            string password = txt_logPassword.Text.Trim();

            if (txt_logEmail.Text.Trim() == "" || txt_logPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            // checking if email exists
            bool teacherExist = TeacherEmailExists(txt_logEmail.Text);
            bool studentExist = StudentEmailExists(txt_logEmail.Text);

            if (!teacherExist && !studentExist)
            {
                MessageBox.Show("This email does not exist");
                txt_logEmail.Focus();
                return;

            }
            if (teacherExist)
            {
                String queryTeacher = "SELECT TeacherId FROM Teacher WHERE Email = @email AND PasswordHash = @password";
                SqlCommand cmdTeacher = new SqlCommand(queryTeacher, conn);
                cmdTeacher.Parameters.AddWithValue("@email", email);
                cmdTeacher.Parameters.AddWithValue("@password", password);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmdTeacher.ExecuteReader();

                    if (reader.Read())
                    {
                        int teacherId = reader.GetInt32(0);
                        reader.Close();
                        conn.Close();

                        MessageBox.Show("Teacher login successful");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Invalid email or password");
                    }
                    reader.Close();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                    return;
                }
            }
            String queryStudent = "SELECT StudentId FROM Student WHERE Email = @email AND PasswordHash = @password";
            SqlCommand cmdStudent = new SqlCommand(queryStudent, conn);
            cmdStudent.Parameters.AddWithValue("@email", email);
            cmdStudent.Parameters.AddWithValue("@password", password);

            try
            {
                conn.Open();
                SqlDataReader reader = cmdStudent.ExecuteReader();

                if (reader.Read())
                {
                    int studentId = reader.GetInt32(0);
                    reader.Close();
                    conn.Close();

                    MessageBox.Show("Student login successful");
                    return;
                }
                else
                {
                    MessageBox.Show("Invalid email or password");
                }
                reader.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                conn.Close();
                return;
            }

            MessageBox.Show("Invalid email or password");
        }

        private void btn_up_Click(object sender, EventArgs e)
        {
            if (txt_name.Text.Trim() == "" || txt_regEmail.Text.Trim() == "" || txt_regPassword.Text.Trim() == "")
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

        private void btn_regCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ll_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = Login_page;
        }

        private void ll_login_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectedTab = Register_page;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            txt_logPassword.PasswordChar = cb_reg.Checked ? '\0' : '*';
        }

        private void cb_reg_CheckedChanged(object sender, EventArgs e)
        {
            txt_regPassword.PasswordChar = cb_reg.Checked ? '\0' : '*';
        }

        private void cb_log_CheckedChanged(object sender, EventArgs e)
        {
            txt_logPassword.PasswordChar = cb_log.Checked ? '\0' : '*';
        }
    }
}
