using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class StudentForm : System.Web.UI.Page
{
    string conStr =
        ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            LoadStudents();
        }
    }

    protected void btnSave_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(conStr);

        string query =
            "INSERT INTO Students(Name, Email) VALUES(@Name, @Email)";

        SqlCommand cmd = new SqlCommand(query, con);

        cmd.Parameters.AddWithValue("@Name", txtName.Text);
        cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

        con.Open();
        cmd.ExecuteNonQuery();
        con.Close();

        lblMessage.Text = "Data Inserted Successfully";

        txtName.Text = "";
        txtEmail.Text = "";

        LoadStudents();
    }

    private void LoadStudents()
    {
        SqlConnection con = new SqlConnection(conStr);

        string query = "SELECT * FROM Students";

        SqlDataAdapter da = new SqlDataAdapter(query, con);

        DataTable dt = new DataTable();

        da.Fill(dt);

        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}