<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListCliente.aspx.cs" Inherits="Admin.ListCliente" %>

<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %> <!--mensaje mostrado en java script cuando se produce un error -->
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
    <title>| Sistema Admin | Listado Clientes|</title>
	
	<link rel="stylesheet" href="Styles/estilo.css" type="text/css"/> <!--hoja de estilos -->
    <link rel="stylesheet" href="Styles/estilos.css" type="text/css"/> <!--hoja de estilos -->

	<script src="Util.js" type="text/javascript"></script>

  <meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1"><style type="text/css">BODY {
	FONT-SIZE: 8.5pt
}
TD {
	FONT-SIZE: 8.5pt
}
TH {
	FONT-SIZE: 8.5pt
}
BODY {
	BACKGROUND-IMAGE: url(Images/fondo.jpg); BACKGROUND-COLOR: #ffffff
}
</style></head>
  
  <body>
 <MsgBox:UCMessageBox ID="messageBox" runat="server" ></MsgBox:UCMessageBox>
  <form id="form1" runat="server">
<table width="1000" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#ffffff">
    <tr>
      <td colspan="4"><img src="Images/titulo.jpg" width="1000" height="143"></td>
    </tr>
    <tr>
      <td width="200" rowspan="2" align="left" valign="top" bgcolor="#37703e"><uc1:UCNavigation id="UserControl2" runat="server"></uc1:UCNavigation></td>
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> Listado de Clientes</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">

      <!--parte blanca escriba aqui -->
          <asp:GridView ID="gridClientes" runat="server" CssClass="subtitulo" EmpyDataText="No Existen Registros"
              GridLines="Horizontal" AutoGenerateColumns="False" OnRowCommand="gridClientes_RowCommand"> 
              <HeaderStyle CssClass="registroTitulo" Font-Size="10px" />
                   <AlternatingRowStyle CssClass ="registroNormal" Font-Size="10px" />
                   <RowStyle CssClass="registroAlternado" Font-Size="10px" />
            
              <Columns>
                  <asp:TemplateField HeaderText="Id" HeaderStyle-Width="30px">
                   
                       <ItemTemplate>
                           <asp:Label runat="server" ID="lblClienteId" Text='<%# Eval("Id") %>'></asp:Label>
                       </ItemTemplate>

                   </asp:TemplateField>

                  <asp:TemplateField HeaderText="Nombre y Apellido" HeaderStyle-Width="200px">
                   
                       <ItemTemplate>
                           <asp:Label runat="server" ID="lblNombre" Text='<%# Eval("Nombre") %>'></asp:Label>
                       </ItemTemplate>

                   </asp:TemplateField>

                  <asp:TemplateField HeaderText="Domicilio" HeaderStyle-Width="150px">
                   
                       <ItemTemplate>
                           <asp:Label runat="server" ID="lblDomicilio" Text='<%# Eval("Domicilio") %>'></asp:Label>
                       </ItemTemplate>

                   </asp:TemplateField>
                  <asp:TemplateField HeaderText="Telefono" HeaderStyle-Width="100px">
                   
                       <ItemTemplate>
                           <asp:Label runat="server" ID="lblTelefono" Text='<%# Eval("Telefono") %>'></asp:Label>
                       </ItemTemplate>

                   </asp:TemplateField>
                  <asp:TemplateField HeaderText="Email" HeaderStyle-Width="100px">
                   
                       <ItemTemplate>
                           <asp:Label runat="server" ID="lblEmail" Text='<%# Eval("Email") %>'></asp:Label>
                       </ItemTemplate>

                   </asp:TemplateField>
            
                  <asp:TemplateField HeaderText="Acciones" HeaderStyle-Width="100px">
                   
                       <ItemTemplate>
                           <asp:ImageButton runat="server" ID="btnEditar" AlternateText="Editar Cliente" ToolTip="Editar Cliente" CssClass="cBotones" ImageUrl="Images/edit.png" CommandName="EditarCliente" CommandArgument='<%# Eval("Id") %>' />
                           <asp:ImageButton runat="server" ID="btEliminar" AlternateText="Eliminar Cliente" ToolTip="Eliminar Cliente" CssClass="cBotones" ImageUrl="Images/btneliminar.png" CommandName="EliminarCliente" CommandArgument='<%# Eval("Id") %>' />
                       </ItemTemplate>

                   </asp:TemplateField>
              </Columns>
          </asp:GridView>

        </td>
      
    </tr>
    <tr>
      <td width="200" height="30" bgcolor="#d2d2c6">&nbsp;</td>
      <td width="10" bgcolor="#d2d2c6">&nbsp;</td>
      <td width="770" bgcolor="#d2d2c6">&nbsp;</td>
      <td width="20" bgcolor="#d2d2c6">&nbsp;</td>
    </tr>
  </table>
   
  
    </form>
</body>
</html>