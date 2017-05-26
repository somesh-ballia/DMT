using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class CreateTable2 : System.Web.UI.Page
{

    int number = 0;

    SqlConnection connection;
    SqlDataAdapter DA;
    DataSet DS = new DataSet();
    SqlCommand cmd;

    protected void Page_Load(object sender, EventArgs e)
    {

        string table = Session["Table"].ToString();
        string count = Session["Count"].ToString();
        number = Convert.ToInt32(count);
        for (int i = 0; i < number; i++)
        {
            Label lble = new Label();
            lble.ID = "Lable" + i;
            lble.Text = "Column";
            //  this.form1.Controls.Add(new LiteralControl("      "));

            TextBox tb = new TextBox();
            tb.Width = 150;
            tb.Height = 18;
            tb.TextMode = TextBoxMode.SingleLine;
            tb.ID = "TextBoxID" + i.ToString();
            //  this.form1.Controls.Add(new LiteralControl("      "));

            Label lbleType = new Label();
            lbleType.ID = "LableType" + i.ToString();
            lbleType.Text = "Data Type";
            // this.form1.Controls.Add(new LiteralControl("      "));

            DropDownList ddl = new DropDownList();
            ddl.ID = "DropDownList" + i.ToString();
            ddl.Items.Add("varchar");
            ddl.Items.Add("int");
            //this.form1.Controls.Add(new LiteralControl("      "));

            Label lbleSize = new Label();
            lbleSize.ID = "LableSize" + i.ToString();
            lbleSize.Text = "Size";
            // this.form1.Controls.Add(new LiteralControl("      "));

            TextBox tbSize = new TextBox();
            tbSize.Width = 150;
            tbSize.Height = 18;
            tbSize.TextMode = TextBoxMode.SingleLine;
            tbSize.ID = "TextBoxSizeID" + (i).ToString();

            this.form1.Controls.Add(lble);
            this.form1.Controls.Add(tb);
            this.form1.Controls.Add(lbleType);
            this.form1.Controls.Add(ddl);
            this.form1.Controls.Add(lbleSize);
            this.form1.Controls.Add(tbSize);
            this.form1.Controls.Add(new LiteralControl("<br/>"));
        }      

    }
    
    protected void ButtonCreateTable_Click(object sender, EventArgs e)
    {
        string query = "create table " + Session["Table"] + " ( "; ;
        connection = new SqlConnection(Session["ConnectionString"].ToString());
        for (int i = 0; i < number; i++)
        {
            string boxName = "TextBoxID" + i;
            TextBox tb = this.form1.FindControl(boxName) as TextBox;
            string ColumnName = tb.Text;

            string DropDownListName = "DropDownList" + i.ToString();
            DropDownList ddl = this.form1.FindControl(DropDownListName) as DropDownList;
            string ColumnType = ddl.Text;

            string boxSize = "TextBoxSizeID" + (i).ToString();
            TextBox tbSize = this.form1.FindControl(boxSize) as TextBox;
            string ColumnSize = tbSize.Text;

            if (ColumnType == "varchar")
            {
                if (i == 0)
                {
                    query += ColumnName + " " + ColumnType + "(" + ColumnSize + ")";
                }
                else
                {
                    query += "," + ColumnName + " " + ColumnType + "(" + ColumnSize + ")";
                }
            }
            else
            {
                if (i == 0)
                {
                    query += ColumnName + " " + ColumnType;

                }
                else
                {
                    query += ","+ ColumnName + " " + ColumnType;
                }
            }

        }
        query += ")";
        cmd = new SqlCommand(query, connection);
        try
        {
            connection.Open();
            cmd.ExecuteNonQuery();
            connection.Close();
            LabelStatus.Text = "Table Created";
        }
        catch (Exception ex)
        {
            LabelStatus.Text = ex.Message;
        }
    }    
}