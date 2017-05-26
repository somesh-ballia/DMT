using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class DeleteColumn1 : System.Web.UI.Page
{

    SqlConnection connection;
    SqlDataAdapter DA;
    DataSet DS = new DataSet();
    SqlCommand cmd;
    string query = "";


    protected void Page_Load(object sender, EventArgs e)
    {
        connection = new SqlConnection(Session["ConnectionString"].ToString());
        query = "select column_name,* from information_schema.columns  where table_name = '" + Session["Table"] + "'order by ordinal_position";
        DS.Clear();
        DA = new SqlDataAdapter(query, connection);
        DA.Fill(DS, "Column");
        if (DS.Tables["Column"].Rows.Count > 0)
        {
            LabelTable.Text = Session["Table"].ToString();
            int length = DS.Tables["Column"].Rows.Count;
            for (int i = 0; i < length; i++)
            {                
                DropDownListColumn.Items.Add(DS.Tables["Column"].Rows[i][0].ToString());
            }
        }

    }
    protected void ButtonRetrieve_Click(object sender, EventArgs e)
    {
        string column = DropDownListColumn.Text;
        query = "alter table " + Session["Table"].ToString() + " drop column " + column;
        cmd = new SqlCommand(query, connection);
        try
        {
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            LabelStatus.Text = "Column Dropped";

        }
        catch (Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }

    }
}