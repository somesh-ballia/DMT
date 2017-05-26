using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class DRL5 : System.Web.UI.Page
{

    SqlConnection connection;
    SqlDataAdapter DA;
    DataSet DS = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        string[] from = (string[])Session["From"];
        string where = Session["Where"].ToString();
        string table = Session["Table"].ToString();
        string value = Session["value"].ToString();
        string type = Session["type"].ToString();

        string fromList = "";
        int length = from.Length;
        if (length > 0)
        {
            fromList = from[0];

            for (int i = 1; i < length; i++)
            {
                if (from[i] != null)
                    fromList += "," + from[i];
            }
        }

        string query = "";
        if (type == "varchar")
        {
            query = "select " + fromList + " from " + table + " where " + where + " = '" + value + "' ";
        }
        else
        {
            query = "select " + fromList + " from " + table + " where " + where + " = " + value;
        }
        DS.Clear();
        try
        {
            connection = new SqlConnection(Session["ConnectionString"].ToString());
            DA = new SqlDataAdapter(query, connection);
            DA.Fill(DS, "value");
            GridViewDRL5.DataSource = DS.Tables["value"];
            GridViewDRL5.DataBind();

        }
        catch (Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }

    }
}