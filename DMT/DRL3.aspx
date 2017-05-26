<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DRL3.aspx.cs" Inherits="DRL3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:GridView ID="GridViewDRL3" runat="server" Height="219px" Width="397px" 
        onselectedindexchanged="GridViewDRL3_SelectedIndexChanged">
    </asp:GridView>
    <p>
        <asp:Label ID="LabelStatus" runat="server" ForeColor="Red"></asp:Label>
    </p>
    </form>
</body>
</html>
