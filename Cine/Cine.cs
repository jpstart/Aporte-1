using System;
using System.Collections.Generic;
using System.Text;

namespace Aporte
{
    class Cine
    {
        //Atributos//
        private string nombre;
        private string provincia;
        private string ciudad;
        public Sala[] salas;


        //Contructor//
        public Cine()
        {
            nombre = "Cine Uleam";
            provincia = "Manabí";
            ciudad = "Manta";
            salas = null;
        }
        public Cine(string nombre, string provincia, string ciudad, Sala[] salas)
        {
            this.nombre = nombre;
            this.provincia = provincia;
            this.ciudad = ciudad;
            this.salas = salas;
        }
        //Atributos//
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Provincia
        {
            set { provincia = value; }
            get { return provincia; }
        }
        public string Ciudad
        {
            set { ciudad = value; }
            get { return ciudad; }

        }
        public Sala[] Salas
        {
            set { salas = value; }
            get { return salas; }
        }
    }
}
