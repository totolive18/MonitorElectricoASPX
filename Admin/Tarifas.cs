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
    public partial class Tarifas
    {
        //oobtenemos informacion por parte de la base de datos

        public static DataSet GetTarifas ()
        {

            SqlParameter[]  dbParams = new SqlParameter []
            {};

            return DBHelper.ExecuteDataSet("usp_Tarifas_GetTarifas", dbParams); //Stored procedure , programacion en sql
        }
    }
}