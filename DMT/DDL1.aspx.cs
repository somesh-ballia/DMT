using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DDL1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
    protected void ButtonCreate_Click(object sender, EventArgs e)
    {
        Response.Redirect("CreateTable1.aspx");
    }
    protected void ButtonAlter_Click(object sender, EventArgs e)
    {
        Response.Redirect("Alter1.aspx");
    }
    protected void ButtonDrop_Click(object sender, EventArgs e)
    {
        Response.Redirect("Drop1.aspx");
    }
}