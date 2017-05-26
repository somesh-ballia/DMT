using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class AddKey1 : System.Web.UI.Page
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
            int length = DS.Tables["Column"].Rows.Count;
            for (int i = 0; i < length; i++)
            {
                RadioButtonListColumn.Items.Add(DS.Tables["Column"].Rows[i][0].ToString());                
            }
        }
    }
    protected void ButtonAlter_Click(object sender, EventArgs e)
    {
        int itemIndex = RadioButtonListColumn.SelectedIndex;
        string columnName = RadioButtonListColumn.Items[itemIndex].ToString();
        string query = "alter table " + Session["Table"].ToString() + " add primary key ( " + columnName + ")";
        try
        {
            cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            LabelStatus.Text = "Primary Key Set";
        }
        catch (Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }

    }
}