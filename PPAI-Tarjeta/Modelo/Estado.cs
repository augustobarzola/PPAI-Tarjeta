using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
   public class Estado
    {
        private string nombre;

        //Metodos de seteo
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        //Constructor
        public Estado(string nombre)
        {
            this.nombre = nombre;
        }
        public Estado()
        {
            this.nombre = "";
        }

        //Metodo que comprueba si el estado es Finalizado
        public bool esFinalizado() {
            if (this.nombre == "Finalizado")
                return true;
            else
                return false;
           }

        //Metodo que comprueba si el estado es Iniciada
        public bool esIniciada()
        {
            if (this.nombre == "Iniciada")
                return true;
            else
                return false;
        }
        //Metodo que comprueba si el estado es Iniciada
        public bool esEnCurso()
        {
            if (this.nombre == "En Curso")
                return true;
            else
                return false;
        }
    }
}
