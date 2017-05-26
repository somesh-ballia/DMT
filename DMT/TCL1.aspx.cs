using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TCL1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonDRL_Click(object sender, EventArgs e)
    {
        Session["Join"] = "Inner Join";
        Response.Redirect("Join.aspx");
    }
    protected void ButtonDML_Click(object sender, EventArgs e)
    {
        Session["Join"] = "Left Join";
        Response.Redirect("Join.aspx");
    }
    protected void ButtonDDL_Click(object sender, EventArgs e)
    {
        Session["Join"] = "Right Join";
        Response.Redirect("Join.aspx");
    }
    protected void ButtonTCL_Click(object sender, EventArgs e)
    {
        Session["Join"] = "Full Join";
        Response.Redirect("Join.aspx");
    }
}