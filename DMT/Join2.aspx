<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Join2.aspx.cs" Inherits="InnerJoin2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelJoin" runat="server" Text="Label"></asp:Label>
        <br />
        Join<br />
        <asp:GridView ID="GridViewData" runat="server" 
            onselectedindexchanged="GridViewData_SelectedIndexChanged">
        </asp:GridView>
        <br />
        <br />
        <asp:Label ID="LabelStatus" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
