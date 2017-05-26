using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class DRL4 : System.Web.UI.Page
{
    SqlConnection connection;
    SqlDataAdapter DA;
    DataSet DS = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        //string[] from = (string[])Session["From"];
        string where = Session["Where"].ToString();
        string table = Session["Table"].ToString();
        //string fromList = "";
        LabelTable.Text = table;
        LabelWhere.Text = where;

        //int length = from.Length;
        //if (length > 0)
        //{
        //    fromList = from[0];

        //    for (int i = 1; i < length; i++)
        //    {
        //        if (from[i] != null)
        //            fromList += "," + from[i];
        //    }
        //}
        
        string query = "select " + where + " from " + table;
        DS.Clear();
        try
        {
            connection = new SqlConnection(Session["ConnectionString"].ToString());
            DA = new SqlDataAdapter(query, connection);
            DA.Fill(DS, "value");
            if (DS.Tables["value"].Rows.Count > 0)
            {
                int lengthValue = DS.Tables["value"].Rows.Count;
                for (int i = 0; i < lengthValue; i++)
                {
                    DropDownListValue.Items.Add(DS.Tables["value"].Rows[i][0].ToString());
                }
            }

            query = "select data_type from information_schema.columns where table_name = '" + table + "' and column_name = '" + where + "' ";
            DA = new SqlDataAdapter(query, connection);
            DA.Fill(DS, "type");
            if (DS.Tables["type"].Rows.Count > 0)
            {
                Session["type"] = DS.Tables["type"].Rows[0][0].ToString();
            }


        }
        catch (Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }
    }
    protected void ButtonRetrieve_Click(object sender, EventArgs e)
    {
        string value = DropDownListValue.Text;
        Session["value"] = value;
        Response.Redirect("DRL5.aspx");
    }
}