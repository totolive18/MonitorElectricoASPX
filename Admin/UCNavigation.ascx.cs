using Admin;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Teach
{
    public partial class UCNavigation : System.Web.UI.UserControl
    {
        private void Page_Load(object sender, EventArgs e)
        {
         
            bool Logged = paginaBase.LoggedIn(Session);
           
            if (this.lnkChangePassword.Enabled)
            {
                this.lnkChangePassword.CssClass = "izq";
            }
            else
            {
                this.lnkChangePassword.CssClass = "izqDesactivado";
            }
           

            Page.ClientScript.RegisterStartupScript(Page.GetType(), "tttt", "ocultarEnlaces(" + Logged.ToString().ToLower() + ");", true);
            this.divLogin.Visible = !Logged;
            if (Logged)
           
            {
                this.lnkHome.CssClass = "izq";
               
                this.lblTarifas.CssClass = "izq";
                this.lnkAddTarifas.CssClass = "izqDos";
                this.lnkListTarifas.CssClass = "izqDos";
            
                this.lnkLogout.CssClass = "izq";
            
                this.lnkAddClientes.CssClass = "izqDos";
                this.lnkListCliente.CssClass = "izqDos";
                this.lblClientes.CssClass = "izq";
            }
        }
        protected override void OnInit(EventArgs e)
        {
            this.InitializeComponent();
            base.OnInit(e);
        }
        private void InitializeComponent()
        {
            base.Load += new EventHandler(this.Page_Load);
        }
    }
}