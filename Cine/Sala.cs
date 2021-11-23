using System;

namespace Aporte
{
    public class Sala
    {
        private string nombre;
        private int cantidad_asientos;



        //Contructores//
        public Sala()
        {
            nombre = "Sala 1";
            cantidad_asientos = 0;
      
        }
        public Sala(string nombre, int cantidad_asientos)
        {
            this.nombre = nombre;
            this.cantidad_asientos = cantidad_asientos;
         

        }
        //Propiedades//
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int Cantidad_de_asientos
        {
            set { cantidad_asientos = value; }
            get { return cantidad_asientos; }
        }
        //Metodo String//
        public override string ToString()
        {
            return base.ToString();
        }




    }
}

