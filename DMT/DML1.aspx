<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DML1.aspx.cs" Inherits="DML1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Button ID="ButtonInsert" runat="server" onclick="ButtonInsert_Click" 
            Text="Insert" />
        <br />
        <br />
        <asp:Button ID="ButtonUpdate" runat="server" onclick="ButtonUpdate_Click" 
            Text="Update" />
        <br />
        <br />
        <asp:Button ID="ButtonDelete" runat="server" Text="Delete" 
            onclick="ButtonDelete_Click" />
    
    </div>
    </form>
</body>
</html>
