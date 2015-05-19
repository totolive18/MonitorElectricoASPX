using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Admin.Clases
{
    public class Cliente
    {
        //atributos y metodos que podran accederse desde fuera de la clase
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _nombre;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        private string _domicilio;

        public string Domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }
        private string _telefono;

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        //conductores 1 vacio y otro que inicialize los atributos

        public Cliente ()
        { }
        public Cliente (int id, string nombre, string domicilio, string telefono, string email)
        {
            _id = id;
            _nombre = nombre;
            _domicilio = domicilio;
            _telefono = telefono;
            _email = email;
        }
    }
}