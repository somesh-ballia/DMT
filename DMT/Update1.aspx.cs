﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Update1 : System.Web.UI.Page
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

        }
        catch (Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }

    }
    protected void ButtonRetrieve_Click(object sender, EventArgs e)
    {
        Session["Table"] = DropDownListTables.Text;
        Response.Redirect("Update2.aspx");

    }
}