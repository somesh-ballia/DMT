using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class AddColumn1 : System.Web.UI.Page
{

    SqlConnection connection;
    SqlCommand cmd;
    string query = "";
    string table = "";
    string ColumnName = "";
    string type ="";
    string size ="";
    
    protected void Page_Load(object sender, EventArgs e)
    {
        connection = new SqlConnection(Session["ConnectionString"].ToString());
        table = Session["Table"].ToString();
        ColumnName = TextBoxColumn.Text.Trim();
        type = DropDownListType.Text;
        size = TextBoxSize.Text.Trim();
    }
    protected void ButtonAlter_Click(object sender, EventArgs e)
    {
        query = "alter table " + table + " add "+ColumnName + " " + type;
        if (type == "varchar")
        {
            query += " ( " + size + " )";
        }       

        cmd = new SqlCommand(query, connection);
        try
        {
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            LabelStatus.Text = "Column Added";
        }
        catch (Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }

    }
}