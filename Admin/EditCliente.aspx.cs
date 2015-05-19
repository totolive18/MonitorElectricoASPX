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
    public partial class EditCliente : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //aqui se carga información de la pantalla
            if(!Page.IsPostBack)
            {
                if(Request.QueryString["Id"] != null) //!= distinto
                {
                    int ClienteId = Convert.ToInt32(Request.QueryString["Id"]);
                    CargarDatos(ClienteId);
                }
            }
        }
        //definicion  de metodo cargar datos
        private void CargarDatos(int ClienteId)
        {
            //traemos la informacion de la tabla en esta seccion
            Cliente cliente = new Cliente();
            cliente.Id = ClienteId;
            DataSet ds= EditCliente.GetCliente(cliente); //devolvera un data set
            DataRow dr = ds.Tables[0].Rows[0];

            txtId.Text=ClienteId.ToString();
            txtNombre.Text = dr["Nombre"].ToString();
            txtDomicilio.Text = dr["Domicilio"].ToString();
            txtTelefono.Text = dr["Telefono"].ToString();
            txtEmail.Text = dr["Email"].ToString();
            
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")//significa que estoy modificando de lo contrario es un alta
                {

                    Cliente cliente = new Cliente();
                    cliente.Nombre = txtNombre.Text;
                    cliente.Domicilio = txtDomicilio.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.Email = txtEmail.Text;

                    //llamamos

                    if (EditCliente.Insertar(cliente) > 0)
                    {
                        messageBox.ShowMessage("El cliente se inserto correctamente");
                    }
                }
                else
                {

                    Cliente cliente = new Cliente();
                    cliente.Id = Convert.ToInt32(txtId.Text);
                    cliente.Nombre = txtNombre.Text;
                    cliente.Domicilio = txtDomicilio.Text;
                    cliente.Telefono = txtTelefono.Text;
                    cliente.Email = txtEmail.Text;

                    //llamamos

                    if (EditCliente.Actualizar(cliente) > 0)
                    {
                       // messageBox.ShowMessage("El cliente se Modifico correctamente");
                        Response.Redirect("ListCliente.aspx"); //redireccion
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