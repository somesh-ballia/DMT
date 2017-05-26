using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Insert2 : System.Web.UI.Page
{

    SqlConnection connection;
    SqlDataAdapter DA;
    DataSet DS = new DataSet();
    SqlCommand cmd;
    string query = "";
    string[] columnName;
    string[] columnType;  

    protected void Page_Load(object sender, EventArgs e)
    {
        string table = Session["Table"].ToString(); 
        connection = new SqlConnection(Session["ConnectionString"].ToString());
        query = "select column_name,data_type from information_schema.columns  where table_name = '" + Session["Table"] + "'order by ordinal_position";
        DS.Clear();
        DA = new SqlDataAdapter(query, connection);
        DA.Fill(DS, "Column");
        if (DS.Tables["Column"].Rows.Count > 0)
        {
           // LabelTable.Text = Session["Table"].ToString();
            int length = DS.Tables["Column"].Rows.Count;            
            columnName = new string[length];
            columnType = new string[length];
            for (int i = 0; i < length; i++)
            {
               columnName[i] = DS.Tables["Column"].Rows[i][0].ToString();
               columnType[i] = DS.Tables["Column"].Rows[i][1].ToString();
               Label lble = new Label();
               lble.ID = "Lable" + i;
               lble.Text = columnName[i];
               this.form1.Controls.Add(new LiteralControl("      "));
               TextBox tb = new TextBox();
               tb.Width = 150;
               tb.Height = 18;
               tb.TextMode = TextBoxMode.SingleLine;
               tb.ID = "TextBoxID" + (i).ToString();
                
               this.form1.Controls.Add(lble);
               this.form1.Controls.Add(tb);
               this.form1.Controls.Add(new LiteralControl("<br/>"));
            }            
        }
    }
    protected void ButtonInsert_Click(object sender, EventArgs e)
    {
        string value="";
        if (DS.Tables["Column"].Rows.Count > 0)
        {
            int length = DS.Tables["Column"].Rows.Count;
                      

            for (int i = 0; i < length; i++)
            {
                    string boxName = "TextBoxID" + (i).ToString();
                    TextBox tb = this.form1.FindControl(boxName) as TextBox;
                    string data = tb.Text;

                if (columnType[i].ToString() == "varchar")
                {
                    
                    if (i == 0)
                    {
                        value += "'" + data + "'";
                    }
                    else
                    {
                        value += ",'" + data + "'";
                    }

                }
                else
                {
                    if (i == 0)
                    {
                        value += data;
                    }
                    else
                    {
                        value += "," + data;
                    }
                    
                }
                
            }
        }
        string query = "insert into " + Session["Table"].ToString() + " values ( " + value + " ) ";
        cmd = new SqlCommand(query, connection);
        try
        {
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            LabelStatus.Text = "Data Inserted";
        }
        catch(Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }
    }
}