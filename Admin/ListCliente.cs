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
    public partial class ListCliente
    {
        //se obtiene la información en esta parte de la base de datos
        public static DataSet GetClientes() // devuelve tosos los datos (dataset)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{//DEFINIR PARAMETROS

                  
				};
            return DBHelper.ExecuteDataSet("usp_ListCliente_GetClientes", dbParams); //Stored procedure , programacion en sql
        }

        public static DataSet DeleteCliente(Cliente cliente) // devuelve tosos los datos (dataset)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{//DEFINIR PARAMETROS

                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, cliente.Id), //cliente.nombre clase de la que recibe datos
				};
            return DBHelper.ExecuteDataSet("usp_ListCliente_DeleteCliente", dbParams); //Stored procedure , programacion en sql
        }
    }
}