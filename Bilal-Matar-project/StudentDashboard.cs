using Microsoft.Data.SqlClient;
using System.Data;

namespace Bilal_Matar_project
{
    public partial class StudentDashboard : Form
    {
        static string connString = "Data Source=.\\SQLEXPRESS; Initial Catalog=project_dbvs;Integrated Security=True; TrustServerCertificate=True";
        SqlConnection conn = new SqlConnection(connString);

        int studentId;

        public StudentDashboard(int _studentId)
        {
            InitializeComponent();
            studentId = _studentId;
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {
            txt_Id.Text = studentId.ToString();

            fillStudentName();
            fillGrades();
            fillEvents();
        }

        void fillStudentName()
        {
            string query = "SELECT Name FROM Student WHERE StudentId = " + studentId;
            SqlCommand cmd = new SqlCommand(query, conn);

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    label1.Text = reader.GetString(0);
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
        }

        void fillGrades()
        {
            string query = "SELECT Grade FROM StudentCourse WHERE StudentId = " + studentId;
            SqlCommand cmd = new SqlCommand(query, conn);

            DataTable dtGrades = new DataTable();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtGrades.Load(reader);
                reader.Close();

                dgv_grades.DataSource = dtGrades;
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

        void fillEvents()
        {
            string query = "SELECT EventDescription, EventTime FROM StudentEvent WHERE StudentId = " + studentId + " ORDER BY EventTime DESC";
            SqlCommand cmd = new SqlCommand(query, conn);

            DataTable dtEvents = new DataTable();

            try
            {
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                dtEvents.Load(reader);
                reader.Close();

                dgv_events.DataSource = dtEvents;
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
    }
}
