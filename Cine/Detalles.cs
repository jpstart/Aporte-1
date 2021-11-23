using System;
using System.Collections.Generic;
using System.Text;

namespace Cine
{
    class Detalles
    {
        private string nombre_de_cliente;
        private string nombre_de_pelicula;
        private int sala_de_cine;
        private int Numero_de_butaca;
        private string Aperitivos_y_accesorios;
        private string Productos_comestibles;

        // Constructor
        public Detalles()
        {
            
            nombre_de_cliente = null;
            nombre_de_pelicula = "";
            sala_de_cine = 0;
            Numero_de_butaca = 0;
            Aperitivos_y_accesorios = "";
            Productos_comestibles = "";
           
        }
    }
}
