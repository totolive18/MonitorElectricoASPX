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
    public partial class ListCliente : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //se utiliza la clase List Cliente
           //if para que solo se haga una vez la unica vez que la página se cargue

            if (!Page.IsPostBack)
            {   //refresco
                try
                {
                    CargarGrilla();
                }
                catch (Exception ex)
                {

                    messageBox.ShowMessage(ex.Message);

                }


            }
        }

        private void CargarGrilla()
        {
            DataSet ds = ListCliente.GetClientes();
            gridClientes.DataSource = ds.Tables[0]; // Cuantas tablas puede mostrar
            gridClientes.DataBind(); // carga la grilla
        }
        //cada que se haga click en los eventos editar o eliminar se ejecuta este metodo rowcommand
        protected void gridClientes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            try
            {
                //enviamos id de cliente 
                if (e.CommandName == "EditarCliente")
                { //aqui haremos la actualizacion
                    String sClienteId = e.CommandArgument.ToString(); //tostring especifica objeto
                    Response.Redirect("EditCliente.aspx?Id=" + sClienteId); //redireccion según el id

                }
                else
                    if (e.CommandName == "EliminarCliente")
                    {
                        //creamos un stored procedure de eliminar cliente y en este punto llamamos a dicha clase 

                        Cliente cliente = new Cliente();
                        cliente.Id = Convert.ToInt32(e.CommandArgument.ToString());
                        ListCliente.DeleteCliente(cliente);

                        CargarGrilla();

                    }
            }
            catch (Exception ex)
            {
                
              messageBox.ShowMessage(ex.Message + ex.StackTrace);// muestra linea que produjo error
            }

        }
    }
}