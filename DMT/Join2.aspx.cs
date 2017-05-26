using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class InnerJoin2 : System.Web.UI.Page
{

    SqlConnection connection;
    SqlDataAdapter DA;
    DataSet DS = new DataSet();


    protected void Page_Load(object sender, EventArgs e)
    {
        string query = Session["Query"].ToString();        
        DS.Clear();
        try
        {
            LabelJoin.Text = Session["Join"].ToString();
            connection = new SqlConnection(Session["ConnectionString"].ToString());
            DA = new SqlDataAdapter(query, connection);
            DA.Fill(DS, "Data");
            GridViewData.DataSource = DS.Tables["Data"];
            GridViewData.DataBind();
        }
        catch (Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }
    }
    protected void GridViewData_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}