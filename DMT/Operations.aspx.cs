using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Operations : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonDRL_Click(object sender, EventArgs e)
    {
        Response.Redirect("DRL1.aspx");
    }
    protected void ButtonDML_Click(object sender, EventArgs e)
    {
        Response.Redirect("DML1.aspx");
    }
    protected void ButtonDDL_Click(object sender, EventArgs e)
    {
        Response.Redirect("DDL1.aspx");
    }
    protected void ButtonTCL_Click(object sender, EventArgs e)
    {
        Response.Redirect("TCL1.aspx");
    }
}