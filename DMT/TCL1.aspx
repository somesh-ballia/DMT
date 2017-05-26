<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TCL1.aspx.cs" Inherits="TCL1" %>

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
        .style5
        {
            width: 40px;
        }
        .style6
        {
            width: 196px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
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
                        <td class="style6">
                            Inner Join</td>
                        <td class="style5">
                            <asp:Button ID="ButtonIJ" runat="server" Text="Inner Join" 
                                onclick="ButtonDRL_Click" style="margin-left: 0px" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            Left Join</td>
                        <td class="style5">
                            <asp:Button ID="ButtonLJ" runat="server" Text="Left Join" 
                                onclick="ButtonDML_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            Right Join</td>
                        <td class="style5">
                            <asp:Button ID="ButtonRJ" runat="server" Text="Rignt Join" 
                                onclick="ButtonDDL_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td class="style6">
                            Full Join</td>
                        <td class="style5">
                            <asp:Button ID="ButtonFJ" runat="server" Text="Full Join" 
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
    
    </div>
    </form>
</body>
</html>
