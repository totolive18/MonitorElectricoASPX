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
    public partial class EditTarifas
    {
        public static int Insertar(Tarifa tarifa) //metodo de validar/insertar Cliente
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{//DEFINIR PARAMETROS

                    DBHelper.MakeParam("@NombreTarifa", SqlDbType.VarChar, 0, tarifa.NombreTarifa), //cliente.nombre clase de la que recibe datos
                    DBHelper.MakeParam("@Consumo", SqlDbType.VarChar, 0, tarifa.Consumo),
                    DBHelper.MakeParam("@IntervaloMin", SqlDbType.Int, 0, tarifa.IntervaloMin),
                    DBHelper.MakeParam("@IntervaloMax", SqlDbType.Int, 0, tarifa.IntervaloMax),
                    DBHelper.MakeParam("@CostoTarifa", SqlDbType.Decimal, 0, tarifa.CostoTarifa)
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_EditTarifa_Insertar", dbParams)); //Scalar devuelve el ultimo id insertado
        }
        //modificar cliente


        public static int Actualizar(Tarifa tarifa) //metodo de validar/insertar Cliente
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{//DEFINIR PARAMETROS
                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, tarifa.Id), //cliente.nombre clase de la que recibe datos

                     DBHelper.MakeParam("@NombreTarifa", SqlDbType.VarChar, 0, tarifa.NombreTarifa), //cliente.nombre clase de la que recibe datos
                    DBHelper.MakeParam("@Consumo", SqlDbType.VarChar, 0, tarifa.Consumo),
                    DBHelper.MakeParam("@IntervaloMin", SqlDbType.Int, 0, tarifa.IntervaloMin),
                    DBHelper.MakeParam("@IntervaloMax", SqlDbType.Int, 0, tarifa.IntervaloMax),
                    DBHelper.MakeParam("@CostoTarifa", SqlDbType.Decimal, 0, tarifa.CostoTarifa)
				};
            return Convert.ToInt32(DBHelper.ExecuteScalar("usp_EditTarifa_Actualizar", dbParams)); //Scalar devuelve el ultimo id insertado
        }
        public static DataSet GetTarifa (Tarifa tarifa) // devuelve tosos los datos (dataset)
        {
            SqlParameter[] dbParams = new SqlParameter[]
				{//DEFINIR PARAMETROS

                     DBHelper.MakeParam("@Id", SqlDbType.Int, 0, tarifa.Id), //tarifa.nombre clase de la que recibe datos
				};
            return DBHelper.ExecuteDataSet("usp_EditTarifa_GetTarifa", dbParams); //Stored procedure , programacion en sql
        }
    }
}