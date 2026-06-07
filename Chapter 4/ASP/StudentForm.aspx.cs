using System;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace WebApplication1
{
    public partial class StudentForm : System.Web.UI.Page
    {
        string connStr =
            ConfigurationManager
            .ConnectionStrings["MyDB"]
            .ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadStudents();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            string gender = "";

            if (rbMale.Checked)
                gender = "Male";

            if (rbFemale.Checked)
                gender = "Female";

            string hobbies = "";

            if (chkReading.Checked)
                hobbies += "Reading,";

            if (chkSports.Checked)
                hobbies += "Sports,";

            if (chkMusic.Checked)
                hobbies += "Music,";

            string country = lstCountry.SelectedItem.Text;

            using (MySqlConnection con =
                new MySqlConnection(connStr))
            {
                string query =
                @"INSERT INTO Students
                (FullName,Email,Gender,
                 Department,Hobbies,Country)

                VALUES
                (@name,@email,@gender,
                 @department,@hobbies,@country)";

                MySqlCommand cmd =
                    new MySqlCommand(query, con);

                cmd.Parameters.AddWithValue(
                    "@name", txtName.Text);

                cmd.Parameters.AddWithValue(
                    "@email", txtEmail.Text);

                cmd.Parameters.AddWithValue(
                    "@gender", gender);

                cmd.Parameters.AddWithValue(
                    "@department",
                    ddlDepartment.SelectedValue);

                cmd.Parameters.AddWithValue(
                    "@hobbies", hobbies);

                cmd.Parameters.AddWithValue(
                    "@country", country);

                con.Open();

                cmd.ExecuteNonQuery();

                lblMessage.Text =
                    "Student Saved Successfully";
            }

            LoadStudents();
        }

        private void LoadStudents()
        {
            using (MySqlConnection con =
                new MySqlConnection(connStr))
            {
                string query =
                    "SELECT * FROM Students";

                MySqlDataAdapter da =
                    new MySqlDataAdapter(query, con);

                DataTable dt =
                    new DataTable();

                da.Fill(dt);

                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}