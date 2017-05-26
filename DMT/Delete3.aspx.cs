using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Delete3 : System.Web.UI.Page
{

    SqlConnection connection;
    SqlCommand cmd;
    SqlDataAdapter DA;
    DataSet DS = new DataSet();

    protected void Page_Load(object sender, EventArgs e)
    {        
        string where = Session["Where"].ToString();
        string table = Session["Table"].ToString();        
        LabelTable.Text = table;
        LabelWhere.Text = where;

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
        String query ="";
        try
        {
            if (Session["type"].ToString() == "varchar")
            {
                query = "delete from " + Session["Table"].ToString() + " where " + Session["Where"].ToString() + " =  '" + DropDownListValue.Text + "' ";
            }
            else
            {
                query = "delete from " + Session["Table"].ToString() + " where " + Session["Where"].ToString() + " = " + DropDownListValue.Text;
            }

            cmd = new SqlCommand(query, connection);
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            LabelStatus.Text = "Delete Successfull";

        }
        catch (Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }
    }
}