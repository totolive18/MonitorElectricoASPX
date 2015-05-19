<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UCNavigation.ascx.cs" Inherits="Teach.UCNavigation" %>
<table width="200" border="0" cellspacing="1" cellpadding="0">
    <tr>
      <td height="10" colspan="4"><img src="Images/1.gif" width="198" height="15" /></td>
    </tr>
    <tr id="divLogin" runat="server">
      <td height="20">&nbsp;</td>
      <td bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628"><asp:HyperLink CssClass="izq" ID="lnkCRM" NavigateUrl="Login.aspx" runat="server">CRM Login</asp:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    
    <tr id="divlnkHome">
      <td height="20">&nbsp;</td>
      <td bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628"><ASP:HyperLink CssClass="izq" id="lnkHome"
				 navigateurl="Main.aspx" runat="server">Home</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>


    <!--Tarifa -->

    <tr id="divlblTarifas" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628" class="titleBlanco">
        <ASP:Label id="lblTarifas" runat="server">Tarifas </ASP:Label></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkAddTarifas" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkAddTarifas" runat="server" cssclass="izq2" navigateurl="Tarifas.aspx">Tipo Tarifas </ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkListTarifas" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkListTarifas" runat="server" cssclass="izq2" navigateurl="ListTarifa.aspx">Editar Tarifas </ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>

    <!-- CLIENTES -->

    
    <tr id="divlblClientes" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628" class="titleBlanco">
        <ASP:Label id="lblClientes" runat="server">Clientes:</ASP:Label></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkAddClientes" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkAddClientes" runat="server" cssclass="izq2" navigateurl="EditCliente.aspx">Nuevo Cliente</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkListClientes" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="37703e">&nbsp;</td>
      <td height="20" bgcolor="#225628">&nbsp;&nbsp;&nbsp;&nbsp;
        <ASP:HyperLink id="lnkListCliente" runat="server" cssclass="izq2" navigateurl="ListCliente.aspx">Lista de Clientes</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    
   


    <tr id="divlnkChangePassword" >
      <td height="20">&nbsp;</td>
      <td width="4" bgcolor="#d2d2c6">&nbsp;</td>
      <td height="20" bgcolor="#225628" classname="izq"><ASP:HyperLink id="lnkChangePassword" class="izq"
                       runat="server" navigateurl="ChangePassword.aspx" cssclass="izq">Change Password</ASP:HyperLink></td>
      <td height="20">&nbsp;</td>
    </tr>
    <tr id="divlnkLogout" >
      <td width="10" height="20" style="HEIGHT: 20px">&nbsp;</td>
      <td width="4" bgcolor="#d2d2c6" style="HEIGHT: 20px">&nbsp;</td>
      <td height="20" bgcolor="#225628" style="HEIGHT: 20px">
        <p>
          <ASP:HyperLink id="lnkLogout" runat="server" cssclass="izq2" navigateurl="LogOut.aspx">Log Out</ASP:HyperLink>
        </p></td>
      <td width="10" height="20" style="HEIGHT: 20px">&nbsp;</td>
    </tr>
    <tr style="background:green" runat="server" id="trTipoSitio" visible="false">
      <td width="10">&nbsp;</td>
      <td width="4">&nbsp;</td>
      <td>TESTING...</td>
      <td width="10">&nbsp;</td>
    </tr>
  </table>
  <script language="javascript" type="text/javascript">
      function ocultarEnlaces(b) {
          var cad = 'none';
          if (b) {
              cad = '';
          }

          document.getElementById('divlnkHome').style.display = cad;

          //tarifas

          document.getElementById('divlblTarifas').style.display = cad;
          document.getElementById('divlnkAddTarifas').style.display = cad;
          document.getElementById('divlnkListTarifas').style.display = cad;
         

          //clientes 

          document.getElementById('divlblClientes').style.display = cad;
          document.getElementById('divlnkAddClientes').style.display = cad;
          document.getElementById('divlnkListClientes').style.display = cad;


          
          
          document.getElementById('divlnkChangePassword').style.display = cad;
          document.getElementById('divlnkLogout').style.display = cad;
          
          


      }
  </script>
<p></p>
