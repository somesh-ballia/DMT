<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DRL4.aspx.cs" Inherits="DRL4" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 398px;
        }
        .style2
        {
            width: 261px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Please mention the required condition<br />
        <br />
        <table style="width: 100%; height: 460px;">
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    <table style="width:100%;">
                        <tr>
                            <td class="style2">
                                select from
                                <asp:Label ID="LabelTable" runat="server" Text="Table"></asp:Label>
&nbsp;where
                                <asp:Label ID="LabelWhere" runat="server" Text="Where"></asp:Label>
&nbsp;=
                            </td>
                            <td>
                                <asp:DropDownList ID="DropDownListValue" runat="server">
                                </asp:DropDownList>
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                <asp:Button ID="ButtonRetrieve" runat="server" onclick="ButtonRetrieve_Click" 
                                    Text="Retrieve" Width="96px" />
                            </td>
                        </tr>
                        <tr>
                            <td class="style2">
                                &nbsp;</td>
                            <td>
                                &nbsp;</td>
                        </tr>
                    </table>
                    <asp:Label ID="LabelStatus" runat="server" ForeColor="Red"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td class="style1">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
