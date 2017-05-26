using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class InnerJoin1 : System.Web.UI.Page
{

    SqlConnection connection;
    SqlDataAdapter DA;
    DataSet DS = new DataSet();
    SqlCommand cmd;
    string query0 = "";
    string query1 = "";


    protected void Page_Load(object sender, EventArgs e)
    {
        connection = new SqlConnection(Session["ConnectionString"].ToString());
        query0 = "select column_name,* from information_schema.columns  where table_name = '" + Session["Table0"] + "'order by ordinal_position";
        DS.Clear();
        DA = new SqlDataAdapter(query0, connection);
        DA.Fill(DS, "Column0");
        if (DS.Tables["Column0"].Rows.Count > 0)
        {
            LabelTable0.Text = Session["Table0"].ToString();            
            LabelTable01.Text = Session["Table0"].ToString();            
            int length = DS.Tables["Column0"].Rows.Count;
            for (int i = 0; i < length; i++)
            {
                CheckBoxListColumn.Items.Add(DS.Tables["Column0"].Rows[i][0].ToString());
                DropDownListColumn0.Items.Add(DS.Tables["Column0"].Rows[i][0].ToString());
            }
        }

        query1 = "select column_name,* from information_schema.columns  where table_name = '" + Session["Table1"] + "'order by ordinal_position";
        DS.Clear();
        DA = new SqlDataAdapter(query0, connection);
        DA.Fill(DS, "Column1");
        if (DS.Tables["Column1"].Rows.Count > 0)
        {
            LabelTable1.Text = Session["Table1"].ToString();
            LabelTable11.Text = Session["Table1"].ToString();
            int length = DS.Tables["Column1"].Rows.Count;
            for (int i = 0; i < length; i++)
            {
                CheckBoxListColumn.Items.Add(DS.Tables["Column1"].Rows[i][0].ToString());
                DropDownListColumn1.Items.Add(DS.Tables["Column1"].Rows[i][0].ToString());
            }
        }
    }


    protected void ButtonRetrieve_Click(object sender, EventArgs e)
    {
        string[] from;
        int count = 0;
        string query = "";

        string where0 = DropDownListColumn0.Text;
        string where1 = DropDownListColumn1.Text;
        Session["Where0"] = where0;
        Session["Where1"] = where1;

        int length = CheckBoxListColumn.Items.Count;
        from = new string[length];
        for (int i = 0; i < length; i++)
        {
            if (CheckBoxListColumn.Items[i].Selected)
            {
                from[count] = CheckBoxListColumn.Items[i].Text;
                count++;
            }
        }

        string fromList = "";
        int lengthFrom = from.Length;
        if (length > 0)
        {
            fromList = from[0];

            for (int i = 1; i < length; i++)
            {
                if (from[i] != null)
                    fromList += "," + from[i];
            }
        }

        query = "Select " + fromList + " from " + Session["Table0"].ToString() + " "+ Session["Join"]+ " " + Session["Table1"].ToString() + " ON " + Session["Table0"].ToString() + "." + where0 + " = " + Session["Table1"].ToString() + "." + where1;
        Session["Query"] = query;
        Response.Redirect("Join2.aspx");
    }
}