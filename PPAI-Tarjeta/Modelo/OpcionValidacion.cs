using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
    public class OpcionValidacion
    {
        private bool correcta;
        private string descripcion;

        //Metodos de seteo
        public void setCorrecta(bool correcta)
        {
            this.correcta = correcta;
        }
        public bool getCorrecta()
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
        public OpcionValidacion(bool correcta, string descripcion)
        {
            this.correcta = correcta;
            this.descripcion = descripcion;
        }
        public OpcionValidacion()
        {
            this.correcta = false;
            this.descripcion = "";
        }

        //Metodo que comprueba si validacion es correcto
        public bool esCorrecta(string validar) {
            bool correcta = false;
            if (validar == this.descripcion) {
                correcta = true;
            }
            return correcta;
        }
    }
}
