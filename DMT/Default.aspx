<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true"
    CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .style1
        {
            height: 149px;
        }
        .style2
        {
            height: 144px;
        }
        .style3
        {
            height: 176px;
        }
        .style4
        {
            height: 144px;
            width: 284px;
        }
        .style5
        {
            height: 149px;
            width: 284px;
        }
        .style6
        {
            height: 176px;
            width: 284px;
        }
        .style7
        {
            height: 144px;
            width: 337px;
        }
        .style8
        {
            height: 149px;
            width: 337px;
        }
        .style9
        {
            height: 176px;
            width: 337px;
        }
        .style10
        {
            width: 108px;
        }
        .style11
        {
            width: 181px;
        }
        .style12
        {
            width: 108px;
            height: 54px;
        }
        .style13
        {
            width: 181px;
            height: 54px;
        }
        .style14
        {
            height: 54px;
        }
        .style15
        {
            width: 108px;
            height: 25px;
        }
        .style16
        {
            width: 181px;
            height: 25px;
        }
        .style17
        {
            height: 25px;
        }
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h2>Welcome to sql interactive tool</h2>
    <p>
        <table style="width:100%;">
            <tr>
                <td class="style4">
                </td>
                <td class="style7">
                </td>
                <td class="style2">
                </td>
            </tr>
            <tr>
                <td class="style5">
                </td>
                <td class="style8">
                    <table style="width: 100%; z-index: 1; left: 1px; top: 3px; position: relative; height: 115px;">
                        <tr>
                            <td class="style10">
                                Host Name</td>
                            <td class="style11">
                                <asp:TextBox ID="TextBoxHostName" runat="server" Width="162px">GHOST-MACHINE</asp:TextBox>
                            </td>
                            <td>
                                  &nbsp;</tr>
                        <tr>
                            <td class="style10">
                                Database Name</td>
                            <td class="style11">
                                <asp:TextBox ID="TextBoxDatabase" runat="server" Width="162px">SIT</asp:TextBox>
                            </td>
                            <td>
                                  </tr>
                        <tr>
                            <td class="style10">
                                User Name</td>
                            <td class="style11">
                                <asp:TextBox ID="TextBoxUserName" runat="server" Width="162px">fdsg</asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style10">
                                Password</td>
                            <td class="style11">
                                <asp:TextBox ID="TextBoxPassword" runat="server" Width="162px">fd</asp:TextBox>
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style10">
                                &nbsp;</td>
                            <td class="style11">
                               &nbsp&nbsp&nbsp 
                                <asp:CheckBox ID="CheckBoxWindowsAuthentication" runat="server" 
                                    Text="Windows Authentication" Checked="True" />
                            </td>
                            <td>
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td class="style12">
                            </td>
                            <td class="style13">
                                &nbsp&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                                    ID="ButtonLogin" runat="server" Text="Login" onclick="ButtonLogin_Click" />
                            </td>
                            <td class="style14">
                            </td>
                        </tr>
                        <tr>
                            <td class="style15">
                                Status:</td>
                            <td class="style16">
                                <asp:Label ID="LabelStatus" runat="server" ForeColor="Red"></asp:Label>
                            </td>
                            <td class="style17">
                            </td>
                        </tr>
                    </table>
                </td>
                <td class="style1">
                </td>
            </tr>
            <tr>
                <td class="style6">
                </td>
                <td class="style9">
                </td>
                <td class="style3">
                </td>
            </tr>
        </table>
    </p>
    </asp:Content>
