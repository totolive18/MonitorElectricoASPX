using Admin.Clases;
using Admin.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Admin
{
    public partial class EditCompra
    {
        public static int Insertar(Compras compras) //metodo de validar/insertar Cliente
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{//DEFINIR PARAMETROS

                    DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, compras.Descripcion), //cliente.nombre clase de la que recibe datos
                    DBHelper.MakeParam("@FechaCompra", SqlDbType.Date, 0, compras.FechaCompra),
                    DBHelper.MakeParam("@Proveedor", SqlDbType.VarChar, 0, compras.Proveedor.Nombre),
                    DBHelper.MakeParam("@NumeroTicket", SqlDbType.VarChar, 0, compras.NumeroTicket),
                    DBHelper.MakeParam("@Monto", SqlDbType.Decimal, 0, compras.Monto),
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_EditCompras_Insertar", dbParams)); //Scalar devuelve el ultimo id insertado
        }
        //modificar cliente


        public static int Actualizar(Compras compras) //metodo de validar/insertar Cliente
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{//DEFINIR PARAMETROS
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, compras.Id), //cliente.nombre clase de la que recibe datos

                    DBHelper.MakeParam("@Descripcion", SqlDbType.VarChar, 0, compras.Descripcion), //cliente.nombre clase de la que recibe datos
                    DBHelper.MakeParam("@FechaCompra", SqlDbType.Date, 0, compras.FechaCompra),
                    DBHelper.MakeParam("@Proveedor", SqlDbType.VarChar, 0, compras.Proveedor.Nombre),
                    DBHelper.MakeParam("@NumeroTicket", SqlDbType.VarChar, 0, compras.NumeroTicket),
                    DBHelper.MakeParam("@Monto", SqlDbType.Decimal, 0, compras.Monto),
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_EditCompras_Actualizar", dbParams)); //Scalar devuelve el ultimo id insertado
        }
        public static DataSet GetCompras (Compras compras) // devuelve tosos los datos (dataset)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{//DEFINIR PARAMETROS

                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, compras.Id), //cliente.nombre clase de la que recibe datos
				};
            return DBHelper.ExecuteDataSet("usp_EditCompras_GetCompras", dbParams); //Stored procedure , programacion en sql
        }

    }
}