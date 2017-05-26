<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Join1.aspx.cs" Inherits="InnerJoin1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Inner Join<br />
        Select
        <br />
        <asp:CheckBoxList ID="CheckBoxListColumn" runat="server">
        </asp:CheckBoxList>
        <br />
        from
        <br />
        <br />
        <asp:Label ID="LabelTable0" runat="server"></asp:Label>
        <br />
        <br />
        INNER JOIN<br />
        <br />
        <asp:Label ID="LabelTable1" runat="server"></asp:Label>
        <br />
        <br />
        On<br />
        <br />
        <asp:Label ID="LabelTable01" runat="server"></asp:Label>
        &nbsp;&nbsp; .&nbsp;
        <asp:DropDownList ID="DropDownListColumn0" runat="server">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp; =&nbsp;&nbsp;&nbsp;
        <asp:Label ID="LabelTable11" runat="server"></asp:Label>
        &nbsp;&nbsp;&nbsp; .&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListColumn1" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="ButtonRetrieve" runat="server" onclick="ButtonRetrieve_Click" 
            Text="Retrieve" Width="91px" />
        <br />
        <br />
        <br />
                    <asp:Label ID="LabelStatus" runat="server" ForeColor="Red"></asp:Label>
    
    </div>
    </form>
</body>
</html>
