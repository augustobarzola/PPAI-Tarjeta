using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
    public class OpcionValidacion
    {
        private string correcta;
        private string descripcion;

        //Metodos de seteo
        public void setCorrecta(string correcta)
        {
            this.correcta = correcta;
        }
        public string getCorrecta()
        {
            return this.correcta;
        }
        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }
        public string getDescripcion()
        {
            return this.descripcion;
        }
        //Constructor
        public OpcionValidacion(string correcta, string descripcion)
        {
            this.correcta = correcta;
            this.descripcion = descripcion;
        }
        public OpcionValidacion()
        {
            this.correcta = "";
            this.descripcion = "";
        }

        //Metodo que comprueba si validacion es correcto
        public bool esCorrecta(string validar) {
            bool correcta = false;
            if (validar == this.correcta) {
                correcta = true;
            }
            return correcta;
        }
    }
}
