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
    public partial class EditCompra : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")//significa que estoy modificando de lo contrario es un alta
                {

                    Compras compras = new Compras();
                    compras.Descripcion = txtDescripcion.Text;
                    compras.FechaCompra = Convert.ToDateTime(txtFecha.Text); //Conversion a tiempo
                    compras.Proveedor.Nombre = txtProveedor.Text;
                    compras.NumeroTicket = txtNumeroTicket.Text;
                    compras.Monto = Convert.ToDecimal ( txtMonto.Text);

                    //llamamos

                    if (EditCompra.Insertar(compras) > 0)
                    {
                        messageBox.ShowMessage("La Compra se inserto correctamente");
                    }
                }
                else
                {

                    Compras compras = new Compras();
                    compras.Id = Convert.ToInt32(txtId.Text);

                    compras.Descripcion = txtDescripcion.Text;
                    compras.FechaCompra = Convert.ToDateTime(txtFecha.Text); //Conversion a tiempo
                    compras.Proveedor.Nombre = txtProveedor.Text;
                    compras.NumeroTicket = txtNumeroTicket.Text;
                    compras.Monto = Convert.ToDecimal(txtMonto.Text);

                    //llamamos

                    if (EditCompra.Actualizar(compras) > 0)
                    {
                        // messageBox.ShowMessage("El cliente se Modifico correctamente");
                        Response.Redirect("ListCompra.aspx"); //redireccion
                    }
                }
            }
            catch (Exception ex)
            {

                messageBox.ShowMessage(ex.Message + ex.StackTrace); // try para errores y nos devuelve la linea donde se produjo nuestro error 
            }


        }

       
    }
}