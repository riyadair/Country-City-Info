<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CountryIntryWabForm.aspx.cs" Inherits="CountryCityWabApp.CountryIntryWabForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="countryNameLabel" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="countryNameTextBox" runat="server"></asp:TextBox>
    
    </div>
        <asp:Label ID="countryAboutLabel" runat="server" Text="About"></asp:Label>
        <asp:TextBox ID="countryAboutTextBox" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="Save" />
            <asp:Button ID="cancelButton" runat="server" Text="Cancel" />
        </p>
        <asp:GridView ID="countryGridView" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
