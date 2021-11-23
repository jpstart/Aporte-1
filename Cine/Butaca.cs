using System;
using System.Collections.Generic;
using System.Text;
namespace Cine
{
     class Butaca
    {
        //atributos//
        private int numero;
        private int estado;
        //Constructor//
        public Butaca()
        {
            numero = 0;
            estado = 0;
        }
        public Butaca(int numero, int estado)
        {
            this.numero = numero;
            this.estado = estado;
        }
        // Propiedades
        public int Numero
        {
            set { numero = value; }
            get { return numero; }
        }
        public int Estado
        {
            set { estado = value; }
            get { return estado; }
        }
        // Métodos toString
        public override string ToString()
        {
            return base.ToString();
        }
    }

}
 
