<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SimpleDarts.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="dartboardImage" runat="server" ImageUrl="dartboard.jpg" />
        <br />
        <br />
        <asp:Button ID="commenceGameButton" runat="server" OnClick="commenceGameButton_Click" Text="Throw Darts!" />
        <br />
        <br />
        <asp:Label ID="finalScoreLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
