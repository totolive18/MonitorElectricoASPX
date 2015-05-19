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
    public partial class EditTarifas : paginaBase
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //aqui se carga información de la pantalla
            if (!Page.IsPostBack)
            {
                if (Request.QueryString["Id"] != null) //!= distinto
                {
                    int TarifaId = Convert.ToInt32(Request.QueryString["Id"]);
                    CargarDatos(TarifaId);
                }
            }
        }
        //definicion  de metodo cargar datos
        private void CargarDatos(int TarifaId)
        {
            //traemos la informacion de la tabla en esta seccion
            Tarifa tarifa = new Tarifa();
            tarifa.Id = TarifaId;
            DataSet ds = EditTarifas.GetTarifa(tarifa); //devolvera un data set
            DataRow dr = ds.Tables[0].Rows[0];

            txtId.Text = TarifaId.ToString();
            txtNombreTarifa.Text = dr["NombreTarifa"].ToString();
            txtConsumo.Text = dr["Consumo"].ToString();
            txtIntervaloMin.Text = dr["IntervaloMin"].ToString();
            txtIntervaloMax.Text = dr["IntervaloMax"].ToString();
            txtCostoTarifa.Text = dr["CostoTarifa"].ToString();

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text == "")//significa que estoy modificando de lo contrario es un alta
                {

                    Tarifa tarifa = new Tarifa();
                    tarifa.NombreTarifa = txtNombreTarifa.Text;
                    tarifa.Consumo = txtConsumo.Text;
                    tarifa.IntervaloMin = Convert.ToInt32(txtIntervaloMin.Text);//conversion a entero
                    tarifa.IntervaloMax = Convert.ToInt32(txtIntervaloMax.Text);
                    tarifa.CostoTarifa = Convert.ToDecimal(txtCostoTarifa.Text);

                    //llamamos

                    if (EditTarifas.Insertar(tarifa) > 0)
                    {
                        messageBox.ShowMessage("La Tarifa se inserto correctamente");
                    }
                }
                else
                {

                    Tarifa tarifa = new Tarifa();
                    tarifa.Id = Convert.ToInt32(txtId.Text);
                   
                    tarifa.NombreTarifa = txtNombreTarifa.Text;
                    tarifa.Consumo = txtConsumo.Text;
                    tarifa.IntervaloMin = Convert.ToInt32(txtIntervaloMin.Text);//conversion a entero
                    tarifa.IntervaloMax = Convert.ToInt32(txtIntervaloMax.Text);
                    tarifa.CostoTarifa = Convert.ToDecimal(txtCostoTarifa.Text);//conversion float

                    //llamamos

                    if (EditTarifas.Actualizar(tarifa) > 0)
                    {
                        // messageBox.ShowMessage("El cliente se Modifico correctamente");
                        Response.Redirect("Tarifas.aspx"); //redireccion
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