using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Tarifa
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nombreTarifa;

        public string NombreTarifa
        {
            get { return _nombreTarifa; }
            set { _nombreTarifa = value; }
        }
        private string _consumo;

        public string Consumo
        {
            get { return _consumo; }
            set { _consumo = value; }
        }
        private int _intervaloMin;

        public int IntervaloMin
        {
            get { return _intervaloMin; }
            set { _intervaloMin = value; }
        }
        private int _intervaloMax;

        public int IntervaloMax
        {
            get { return _intervaloMax; }
            set { _intervaloMax = value; }
        }
        private decimal _costoTarifa;

        public decimal CostoTarifa
        {
            get { return _costoTarifa; }
            set { _costoTarifa = value; }
        }
    }
}