﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Demoex1.aspx.cs" Inherits="MSTest.Demoex1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Numerator</td>
                    <td>
                        <asp:TextBox ID="txtnumerator" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Denominator</td>
                    <td>
                        <asp:TextBox ID="txtdenominator" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        Result
                    </td>
                    <td>
                        <asp:TextBox ID="txtresult" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
