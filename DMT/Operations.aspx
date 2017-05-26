<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Operations.aspx.cs" Inherits="Operations" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 512px;
        }
        .style2
        {
            height: 328px;
        }
        .style3
        {
            width: 512px;
            height: 328px;
        }
        .style4
        {
            width: 529px;
        }
        .style5
        {
            width: 40px;
        }
    </style>
</head>
<body style="height: 177px">
    <form id="form1" runat="server">
    <div>
    
    </div>
    <table style="width: 100%; height: 686px;">
        <tr>
            <td>
                &nbsp;</td>
            <td class="style1">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
            </td>
            <td class="style3">
                <table style="width: 100%;height: 159px;" border="2">
                    <tr>
                        <td class="style4">
                            Data Retrieval Language</td>
                        <td class="style5">
                            <asp:Button ID="ButtonDRL" runat="server" Text="DRL" 
                                onclick="ButtonDRL_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            Data Manipulation Language</td>
                        <td class="style5">
                            <asp:Button ID="ButtonDML" runat="server" Text="DML" 
                                onclick="ButtonDML_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            Data Defination Language</td>
                        <td class="style5">
                            <asp:Button ID="ButtonDDL" runat="server" Text="DDL" 
                                onclick="ButtonDDL_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style4">
                            Transaction Control Language</td>
                        <td class="style5">
                            <asp:Button ID="ButtonTCL" runat="server" Text="TCL" 
                                onclick="ButtonTCL_Click" />
                        </td>
                    </tr>
                </table>
            </td>
            <td class="style2">
            </td>
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
    </form>
</body>
</html>
