using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Compras
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }
        private DateTime _fechaCompra;

        public DateTime FechaCompra
        {
            get { return _fechaCompra; }
            set { _fechaCompra = value; }
        }
        private decimal _monto;

        public decimal Monto
        {
            get { return _monto; }
            set { _monto = value; }
        }
        private string _numeroTicket;

        public string NumeroTicket
        {
            get { return _numeroTicket; }
            set { _numeroTicket = value; }
        }
        private Proveedor _proveedor;

        public Proveedor Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        } 

        //conductores

        public Compras ()
        {
            Proveedor = new Proveedor();

        }
        public Compras (int id, string descripcion, DateTime fechaCompra, Proveedor proveedor, string numeroTicket, decimal monto )
        {
            _id = id;
            _descripcion = descripcion;
            _fechaCompra = fechaCompra;
            _proveedor = proveedor;
            _numeroTicket = numeroTicket;
            _monto = monto;

        }
    }
}