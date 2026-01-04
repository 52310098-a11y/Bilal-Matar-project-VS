using Microsoft.Data.SqlClient;
using System.Data;

namespace Bilal_Matar_project
{
    public partial class TeacherDashboard : Form
    {
        static string connString = "Data Source=.\\SQLEXPRESS; Initial Catalog=project_dbvs;Integrated Security=True; TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);

        int teacherId;

        public TeacherDashboard(int _teacherId)
        {
            InitializeComponent();
            teacherId = _teacherId;
            txt_id.Text = teacherId.ToString();
        }

        private void TeacherDashboard_Load(object sender, EventArgs e)
        {
            fillStudentsCombo();
            fillStudentsGrid();
            cb_student.SelectedIndex = -1;
            nd_grade.Value = 0;
        }

        void fillStudentsCombo()
        {
            string query = "SELECT StudentId, Name FROM dbo.Student";
            SqlCommand cmd = new SqlCommand(query, conn);

            DataTable dtStudents = new DataTable();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtStudents.Load(reader);
                reader.Close();

                cb_student.DataSource = dtStudents;
                cb_student.DisplayMember = "Name";
                cb_student.ValueMember = "StudentId";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        void fillStudentsGrid()
        {
            // Shows all students + grade for THIS teacher (null if not graded yet)
            string query =
                "SELECT s.StudentId, s.Name, ISNULL(sc.Grade, 0) AS Grade " +
                "FROM dbo.Student s " +
                "LEFT JOIN dbo.StudentCourse sc ON sc.StudentId = s.StudentId AND sc.TeacherId = " + teacherId;

            SqlCommand cmd = new SqlCommand(query, conn);

            DataTable dt = new DataTable();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dt.Load(reader);
                reader.Close();

                dgv_students.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        bool GradeRowExists(int studentId)
        {
            bool exists = false;

            string query = "SELECT COUNT(*) FROM dbo.StudentCourse WHERE StudentId = @sid AND TeacherId = @tid";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@sid", studentId);
            cmd.Parameters.AddWithValue("@tid", teacherId);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    // ✅ FIX: COUNT(*) usually returns Int32 in SQL Server
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

        private void btn_grade_Click(object sender, EventArgs e)
        {
            if (cb_student.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student.");
                cb_student.Focus();
                cb_student.DroppedDown = true;
                return;
            }

            int studentIdSelected = (int)cb_student.SelectedValue;
            decimal grade = nd_grade.Value; // numeric up-down returns decimal

            // If row exists -> UPDATE, else -> INSERT
            bool exists = GradeRowExists(studentIdSelected);

            string query;

            if (exists)
            {
                query = "UPDATE dbo.StudentCourse SET Grade = @grade WHERE StudentId = @sid AND TeacherId = @tid";
            }
            else
            {
                query = "INSERT INTO dbo.StudentCourse (StudentId, TeacherId, Grade) VALUES (@sid, @tid, @grade)";
            }

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@sid", studentIdSelected);
            cmd.Parameters.AddWithValue("@tid", teacherId);
            cmd.Parameters.AddWithValue("@grade", grade);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Grade saved successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            fillStudentsGrid();
            cb_student.SelectedIndex = -1;
            nd_grade.Value = 0;
        }
    }
}
