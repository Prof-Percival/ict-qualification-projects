<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta charset="utf-8" />
    <title>Hardin Page</title>    
    <style type="text/css">
        #Text2 {
            width: 193px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">   
        <p>
            <input id="Text1" type="text" /></p>
        <p>
            &nbsp;</p>
        <p>
            Hello World</p>
        <asp:Label ID="Label1" runat="server" Text="TextBox Label" for="Text2"></asp:Label>
        <input id="Text2" formmethod="get" type="text" /></form>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</body>
</html>
