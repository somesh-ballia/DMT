using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI.WebControls;

public partial class Update3 : System.Web.UI.Page
{

    SqlConnection connection;
    SqlDataAdapter DA;
    DataSet DS = new DataSet();
    SqlCommand cmd;
    string[] from;
    string[] fromType;

    // from is into
    protected void Page_Load(object sender, EventArgs e)
    {
        from = (string[])Session["From"];
        fromType = new string[from.Length]; 

        string where = Session["Where"].ToString();
        string table = Session["Table"].ToString();
        string fromList = "";
        LabelTabel.Text = table;
        LabelWhere.Text = where;

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

            query = "select column_name,data_type from information_schema.columns  where table_name = '" + Session["Table"] + "'order by ordinal_position";
            DS.Clear();
            DA = new SqlDataAdapter(query, connection);
            DA.Fill(DS, "Column");
            if (DS.Tables["Column"].Rows.Count > 0)
            {
                int lengthColumn = DS.Tables["Column"].Rows.Count;
                for (int j = 0; j < from.Length; j++)
                {
                    for (int i = 0; i < lengthColumn; i++)
                    {
                        if (DS.Tables["Column"].Rows[i][0].ToString() == from[j])
                        {
                            fromType[j] = DS.Tables["Column"].Rows[i][1].ToString();
                            this.form1.Controls.Add(new LiteralControl("<br/>"));
                            Label lble = new Label();
                            lble.ID = "Lable" + j;
                            lble.Text = from[j];
                            this.form1.Controls.Add(new LiteralControl("      "));
                            TextBox tb = new TextBox();
                            tb.Width = 150;
                            tb.Height = 18;
                            tb.TextMode = TextBoxMode.SingleLine;
                            tb.ID = "TextBoxID" + (j).ToString();

                            this.form1.Controls.Add(lble);
                            this.form1.Controls.Add(tb);
                            this.form1.Controls.Add(new LiteralControl("<br/>"));
                        }
                    }
                }                
            }
        }
        catch (Exception ex)
        {
           // LabelStatus.Text = ex.Message;
        }

    }
    protected void ButtonUpdate_Click(object sender, EventArgs e)
    {
        string value = "";
        if (DS.Tables["Column"].Rows.Count > 0)
        {
            int length = from.Length;
            for (int i = 0; i < length; i++)
            {
                if (from[i] == null)
                {
                    length = i;
                    break;
                }
            }

            for (int i = 0; i < length; i++)
            {
                string boxName = "TextBoxID" + (i).ToString();
                TextBox tb = this.form1.FindControl(boxName) as TextBox;
                string data = tb.Text;

                if (fromType[i].ToString() == "varchar")
                {

                    if (i == 0)
                    {
                        string temp = from[i] + "=";
                        value += temp+ "'" + data + "'";
                    }
                    else
                    {
                        string temp = from[i] + "=";
                        value += ", "+ temp + "'" +data + "' ";
                    }

                }
                else
                {
                    if (i == 0)
                    {
                        string temp = from[i] + "=";
                        value += temp + data;
                    }
                    else
                    {
                        string temp = from[i] + "=";
                        value += ","+ temp +  data;
                    }

                }
            }
        }

        string query = "update " + Session["Table"].ToString() + " Set " + value + " where " + Session["Where"].ToString() + " = '" + DropDownListValue.Text + "' "; 
        cmd = new SqlCommand(query, connection);
        try
        {
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            LabelStatus.Text = "Updated";
        }
        catch (Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }
    }
}