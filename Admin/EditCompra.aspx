<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditCompra.aspx.cs" Inherits="Admin.EditCompra" %>

<%@ Register TagPrefix="MsgBox" Src="UCMessageBox.ascx" TagName="UCMessageBox" %> <!--mensaje mostrado en java script cuando se produce un error -->
<%@ Register TagPrefix="uc1" TagName="UCNavigation" Src="UCNavigation.ascx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.01 Transitional//EN">

<html>
<head>
    <title>| Sistema Admin | Compras|</title>
	
	<link rel="stylesheet" href="Styles/estilo.css" type="text/css"/>
	<script src="Util.js" type="text/javascript"></script>
    <script src="js/jquery-ui-1.8rc3.custom.min.js" ></script>
    <script src="js/jquery.js""></script>
    <link href="Styles/jquery-ui-1.8rc3.custom.css" rel="stylesheet" />
    <link href="Styles/simpleAutoComplete.css" rel="stylesheet" />

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
</style>


     <script >

         $(function () {
             $("#txtFecha").datepicker({
                 dateFormat: 'dd/mm/yy', showOn: 'button', buttonImage: 'images/Calendar_scheduleHS.png', buttonImageOnly: true, changeMonth: true,
                 changeYear: true, gotoCurrent: true
             });
         });
     </script>
</head>
  
  <body>
 <MsgBox:UCMessageBox ID="messageBox" runat="server" ></MsgBox:UCMessageBox>
  <form id="form1" runat="server">
<table width="1000" border="0" align="center" cellpadding="0" cellspacing="0" bgcolor="#ffffff">
    <tr>
      <td colspan="4"><img src="Images/titulo.jpg" width="1000" height="143"></td>
    </tr>
    <tr>
      <td width="200" rowspan="2" align="left" valign="top" bgcolor="#37703e"><uc1:UCNavigation id="UserControl2" runat="server"></uc1:UCNavigation></td>
	  <td height="20" colspan="3" valign="top"  >&nbsp; <h2> Alta de Compras</h2></td>
    </tr>
    <tr>
      <td width="10" height="350" valign="top">&nbsp;</td>
      <td width="770" valign="top" colspan="3">

      <!--CONTROLES DE CLIENTES -->

          <table>
              <tr>
                  <td>

                      <asp:Label runat="server" Text="Id Compra :" ID="labelClienteId"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtId"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td>

                      <asp:Label runat="server" Text="Descripcion :" ID="label1"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtDescripcion" TextMode="MultiLine" Rows="3"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="rfvValidarDescripcion" runat="server" errormessage="La descripción es obligatoria" controltovalidate="txtDescripcion" display="Dynamic"></ASP:RequiredFieldValidator> <!--validador-->
                  </td>
              </tr>
              <tr>
                  <td>

                      <asp:Label runat="server" Text="Fecha de Compra :" ID="label2"></asp:Label>
                     
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtFecha"></asp:TextBox>
                       <ASP:RequiredFieldValidator id="RequiredFieldValidator2" runat="server" errormessage="La Fecha es obligatoria" controltovalidate="txtFecha" display="Dynamic"></ASP:RequiredFieldValidator> <!--validador-->
                  </td>
              </tr>
               <tr>
                  <td>

                      <asp:Label runat="server" Text="Monto :" ID="label4"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtMonto"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator1" runat="server" errormessage="El Monto de la Compra es Obligatorio" controltovalidate="txtMonto" display="Dynamic"></ASP:RequiredFieldValidator> <!--validador-->
                  </td>
              </tr>

               <tr>
                  <td>

                      <asp:Label runat="server" Text="Proveedor :" ID="label5"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtProveedor"></asp:TextBox>
                      <ASP:RequiredFieldValidator id="RequiredFieldValidator3" runat="server" errormessage="El Proveedor es Obligatorio" controltovalidate="txtProveedor" display="Dynamic"></ASP:RequiredFieldValidator> <!--validador-->
                  </td>
              </tr>


              <tr>
                  <td>

                      <asp:Label runat="server" Text="Numero Ticket :" ID="label3"></asp:Label>
                  </td>
                  <td>
                      <asp:TextBox runat="server" ID="txtNumeroTicket"></asp:TextBox>
                  </td>
              </tr>
              <tr>
                  <td>


                      
                   <asp:Button runat="server" ID="btnGuardar" Text="Guardar" CssClass="boton_formulario" OnClick="btnGuardar_Click" />
                  <td>
                     
                  </td>
              </tr>
          </table>



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