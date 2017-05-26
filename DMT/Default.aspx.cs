using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        string databaseName = TextBoxDatabase.Text.Trim();
        string userName = TextBoxUserName.Text.Trim();
        string password = TextBoxPassword.Text.Trim();
        string hostName = TextBoxHostName.Text.Trim();
        string connectionString = "";
        if (databaseName.Length > 0)
        {
            if (userName.Length > 0)
            {
                if (password.Length > 0)
                {
                    if (hostName.Length > 0)
                    {
                        if (CheckBoxWindowsAuthentication.Checked)
                        {
                            connectionString = "Data Source=" + hostName + ";Initial Catalog=" + databaseName + ";Integrated Security=True;Pooling=False";
                        }
                        else
                        {
                            connectionString = "Data Source=" + hostName + ";Initial Catalog=" + databaseName + ";Persist Security Info=True;User ID=" + userName + "; Password=" + password;
                        }
                        Session["ConnectionString"] = connectionString;
                        Session["Database"] = databaseName;
                        try
                        {
                            SqlConnection connection = new SqlConnection(connectionString);
                            connection.Open();
                            connection.Close();
                            Response.Redirect("Operations.aspx");
                        }
                        catch
                        {
                            LabelStatus.Text = "Invalid Data";
                        }                       
                    }
                    else
                    {
                        LabelStatus.Text = "No Host Name Found";
                    }
                }
                else
                {
                    LabelStatus.Text = "No Password Found";
                }
            }
            else
            {
                LabelStatus.Text = "No User Name Found";
            }
        }
        else
        {
            LabelStatus.Text = "No Database Name Found";
        }
             
    }
}
