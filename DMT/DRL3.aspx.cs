using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class DRL3 : System.Web.UI.Page
{

    SqlConnection connection;
    SqlDataAdapter DA;
    DataSet DS = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {
        string[] from = (string []) Session["From"];
        string where = Session["Where"].ToString();
        string fromList = "";
        
        if (where == "all")
        {
            int length = from.Length;
            if (length > 0)
            {
                fromList = from[0];

                for (int i = 1; i < length; i++)
                {
                    if(from[i]!= null)
                    fromList += "," + from[i];
                }
            }
            string query = "select " + fromList + " from " + Session["Table"].ToString();
            DS.Clear();
            try
            {
                connection = new SqlConnection(Session["ConnectionString"].ToString());
                DA = new SqlDataAdapter(query, connection);
                DA.Fill(DS, "Data");
                GridViewDRL3.DataSource = DS.Tables["Data"];
                GridViewDRL3.DataBind();
            }
            catch(Exception ex)
            {
                LabelStatus.Text = ex.Message;
            }
        }
        else
        {
            Response.Redirect("DRL4.aspx");
        }


    }
    protected void GridViewDRL3_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}