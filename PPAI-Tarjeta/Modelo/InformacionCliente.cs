using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
   public class InformacionCliente
    {
        private string datoAValidar;
        private Validacion validacion;
        private OpcionValidacion opcionCorrecta;

        //metodos de seteo
        public void setDatoAValidar(string dato)
        {
            this.datoAValidar = dato;
        }
        public string getDatoAValidar()
        {
            return this.datoAValidar;
        }
        public void setValidacion(Validacion validacion)
        {
            this.validacion = validacion;
        }
        public Validacion getValidacion()
        {
            return this.validacion;
        }
        public void setOpcionCorrecta(OpcionValidacion opcionValidacion)
        {
            this.opcionCorrecta = opcionValidacion;
        }
        public OpcionValidacion getOpcionCorrecta()
        {
            return this.opcionCorrecta;
        }
        //Constructor
        public InformacionCliente(string datoAValidar, Validacion validacion, OpcionValidacion opcionCorrecta)
        {
            this.datoAValidar = datoAValidar;
            this.validacion = validacion;
            this.opcionCorrecta = opcionCorrecta;
        }

        //Metodo que controla que el dato a validar sea correcto
        public bool esInformacionCorrecta(string op) {
            bool retorno=false;
            
                if (this.opcionCorrecta.esCorrecta(op))
                {
                    retorno = true;
                }
                else
                    retorno = false;
            return retorno;
            }

        //Metodo que verifica que el dato sea de validacion
        public bool esValidacion(string nombreValidacion) {
            bool retorno=false;
            if (this.datoAValidar==nombreValidacion) {
                retorno = true;
            }
            return retorno;
        }
    }
}
