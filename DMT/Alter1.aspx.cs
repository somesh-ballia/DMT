using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Alter1 : System.Web.UI.Page
{

    SqlConnection connection;
    SqlDataAdapter DA;
    DataSet DS = new DataSet();
    string query = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            connection = new SqlConnection(Session["ConnectionString"].ToString());
            query = "use " + Session["Database"] + "; select * from sys.tables";
            DS.Clear();
            DA = new SqlDataAdapter(query, connection);
            DA.Fill(DS, "Tables");
            if (DS.Tables["Tables"].Rows.Count > 0)
            {
                int length = DS.Tables["Tables"].Rows.Count;
                for (int i = 0; i < length; i++)
                {
                    DropDownListTables.Items.Add(DS.Tables["Tables"].Rows[i][0].ToString());
                }
            }

            DropDownListChoics.Items.Add("Add Primary Key");
            DropDownListChoics.Items.Add("Add Column");
            DropDownListChoics.Items.Add("Delete Column");            

        }
        catch (Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }

    }
    protected void ButtonGo_Click(object sender, EventArgs e)
    {
        Session["Table"] = DropDownListTables.Text;
        if (DropDownListChoics.Text == "Add Primary Key")
        {
            Response.Redirect("AddKey1.aspx");
        }

        if (DropDownListChoics.Text == "Add Column")
        {
            Response.Redirect("AddColumn1.aspx");
        }

        if (DropDownListChoics.Text == "Delete Column")
        {
            Response.Redirect("DeleteColumn1.aspx");
        }
                
    }
}