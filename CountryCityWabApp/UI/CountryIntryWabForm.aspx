<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryIntryWabForm.aspx.cs" Inherits="CountryCityWabApp.CountryIntryWabForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <table style="height: 147px; width: 263px; margin-right: 217px;">
            <tr>


                <td>
                    <asp:Label ID="countryNameLabel" runat="server" Text="Name"></asp:Label></td>

                <td>
                    <asp:TextBox ID="countryNameTextBox" runat="server"></asp:TextBox></td>

            </tr>
            <tr>
                <td>
                    <asp:Label ID="countryAboutLabel" runat="server" Text="About"></asp:Label></td>
                <td>
                    <asp:TextBox ID="countryAboutTextBox" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
               
                    <td>
                        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" /></td>
                    <td>
                        <asp:Button ID="cancelButton" runat="server" Text="Cancel" /></td>
                
            </tr>
        </table>
        <asp:Label ID="messageLabel" runat="server" Text="" />
        <asp:GridView ID="countryGridView" runat="server" AllowPaging="True">
        </asp:GridView>
    </form>
</body>
</html>
