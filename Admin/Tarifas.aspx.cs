using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Admin.Clases;
using System.Data;


namespace Admin
{
    public partial class Tarifas : paginaBase
    {
        protected void Page_Load (object sender, EventArgs e)
        {
            if (!Page.IsPostBack )
            {
                try
                {
                    CargarGrillaTarifas();
                }
                catch (Exception ex)
                {
                    
                  messageBox.ShowMessage(ex.Message);
                }

            }


        }

        private void CargarGrillaTarifas()
        {
            DataSet ds = Tarifas.GetTarifas();
            gridTarifas.DataSource = ds.Tables[0]; // Cuantas tablas puede mostrar
            gridTarifas.DataBind(); // carga la grilla
        }

        //cada que se haga click en los eventos editar se ejecuta este metodo rowcommand
        protected void gridTarifas_RowCommand (object sender , GridViewCommandEventArgs e)
        {
            try
            {
                if (e.CommandName == "EditarTarifas")
                { //aqui haremos la actualizacion
                    String sTarifasId = e.CommandArgument.ToString(); //tostring especifica objeto
                    Response.Redirect("EditTarifas.aspx?Id=" + sTarifasId); //redireccion según el id

                }
            }
            catch (Exception ex)
            {
                
                 messageBox.ShowMessage(ex.Message + ex.StackTrace);// muestra linea que produjo error
            }
        


        }
    }
}