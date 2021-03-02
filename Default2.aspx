<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:ImageMap ID="ImageMap1" runat="server" ImageUrl="~/resimler/5.jpg" Width="960px">
            <asp:CircleHotSpot NavigateUrl="~/anasayfa.aspx" Radius="600" X="500" Y="500" />
        </asp:ImageMap>
    </form>
</body>
</html>
