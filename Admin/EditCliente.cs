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
    public partial class EditCliente
    {
        public static int Insertar(Cliente cliente) //metodo de validar/insertar Cliente
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{//DEFINIR PARAMETROS

                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.Nombre), //cliente.nombre clase de la que recibe datos
                    DBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, cliente.Domicilio),
                    DBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, cliente.Telefono),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0, cliente.Email)
				};
            return Convert.ToInt32( DBHelper.ExecuteScalar("usp_EditCliente_Insertar", dbParams)); //Scalar devuelve el ultimo id insertado
        }
        //modificar cliente


        public static int Actualizar(Cliente cliente) //metodo de validar/insertar Cliente
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{//DEFINIR PARAMETROS
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.Id), //cliente.nombre clase de la que recibe datos

                    DBHelper.MakeParam("@Nombre", SqlDbType.VarChar, 0, cliente.Nombre), //cliente.nombre clase de la que recibe datos
                    DBHelper.MakeParam("@Domicilio", SqlDbType.VarChar, 0, cliente.Domicilio),
                    DBHelper.MakeParam("@Telefono", SqlDbType.VarChar, 0, cliente.Telefono),
                    DBHelper.MakeParam("@Email", SqlDbType.VarChar, 0, cliente.Email)
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_EditCliente_Actualizar", dbParams)); //Scalar devuelve el ultimo id insertado
        }
        public static DataSet GetCliente(Cliente cliente) // devuelve tosos los datos (dataset)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{//DEFINIR PARAMETROS

                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.Id), //cliente.nombre clase de la que recibe datos
				};
            return DBHelper.ExecuteDataSet("usp_EditCliente_GetCliente", dbParams); //Stored procedure , programacion en sql
        }
    }
}