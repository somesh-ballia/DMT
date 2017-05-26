<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Update2.aspx.cs" Inherits="Update2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Select the table&#39;s attribute you want in the select list<br />
        <br />
        Update
        <asp:CheckBoxList ID="CheckBoxListColumn" runat="server">
        </asp:CheckBoxList>
        <br />
        into<br />
        <br />
        <asp:Label ID="LabelTable" runat="server"></asp:Label>
        <br />
        <br />
        Where<br />
        <br />
        <asp:DropDownList ID="DropDownListColumn" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="ButtonRetrieve" runat="server" onclick="ButtonRetrieve_Click" 
            Text="Retrieve" Width="91px" />
    
    </div>
    </form>
</body>
</html>
