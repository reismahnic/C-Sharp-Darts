<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DartsGame.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="OKBtn" runat="server" OnClick="OKBtn_Click" Text="OK" />
            <br />
            <br />
            <asp:Label ID="ResultsLbl" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>
