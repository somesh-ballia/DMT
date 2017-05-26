<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CreateTable1.aspx.cs" Inherits="CreateTable1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Create Table&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxTable" runat="server"></asp:TextBox>
        <br />
        Number of Columns
        <asp:DropDownList ID="DropDownListColNo" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" onclick="ButtonSubmit_Click" 
            Text="Submit" />
    
    </div>
    </form>
</body>
</html>
