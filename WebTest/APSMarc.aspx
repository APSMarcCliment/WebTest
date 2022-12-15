<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="APSMarc.aspx.cs" Inherits="WebTest.APSMarc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label1" runat="server">UserName</asp:Label>
            <asp:TextBox ID="UserName" runat="server" ToolTip="Enter User Name"></asp:TextBox>
            <p>
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click"/>
            </p>
            <p>
                <asp:Label ID="label2" runat="server"></asp:Label>
            </p>
            <p>
                <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged"></asp:Calendar>   
            </p>
            <p><asp:Label ID="ShowDate" runat="server" ></asp:Label></p>
            <p><asp:Label ID="Especial" runat="server" ></asp:Label></p>
            <p><asp:DropDownList ID="ListaFechas" 
               Width="200" 
               runat="server" 
               AutoPostBack="false" 
               /></p>
        </div>
    </form>
</body>
</html>
