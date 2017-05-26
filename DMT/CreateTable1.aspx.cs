using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CreateTable1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        for (int i = 1; i < 10; i++)
        {
            DropDownListColNo.Items.Add(i.ToString());
        }
    }
    protected void ButtonSubmit_Click(object sender, EventArgs e)
    {
        string table = TextBoxTable.Text.Trim();
        Session["Table"] = table;
        Session["Count"] = DropDownListColNo.Text;
        Response.Redirect("CreateTable2.aspx");
    }
}