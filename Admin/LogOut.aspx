<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOut.aspx.cs" Inherits="Admin.LogOut" %>
<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %> <!--mensaje mostrado en java script cuando se produce un error -->
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <MsgBox:UCMessageBox ID="messageBox" runat="server" ></MsgBox:UCMessageBox>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
</body>
</html>
