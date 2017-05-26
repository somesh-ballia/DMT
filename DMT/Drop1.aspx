<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Drop1.aspx.cs" Inherits="Drop1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <div>
    
        You are guided to the data retrieval part of the tool</div>
    <p>
        Select the Table you want to Drop</p>
    <p>
        <asp:DropDownList ID="DropDownListTables" runat="server">
        </asp:DropDownList>
    </p>
    <asp:Button ID="ButtonRetrieve" runat="server" onclick="ButtonRetrieve_Click" 
        Text="Drop" />
    <br />
    <br />
    <asp:Label ID="LabelStatus" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
