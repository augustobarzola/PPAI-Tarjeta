using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
    public class CambioEstado
    {
        private DateTime fechaHoraInicio;
        private Estado estado;

        //Metodos de seteo
        public void setFechaHoraInicio(DateTime fechaHoraInicio)
        {
            this.fechaHoraInicio = fechaHoraInicio;
        }
        public DateTime getFechaHoraInicio()
        {
            return this.fechaHoraInicio;
        }
        public void setEstado(Estado estado) {
            this.estado = estado;
        }
        public Estado getEstado() {
            return this.estado;
        }

        public string getNombreEstado() {
            return this.estado.getNombre();
        }
        //Constructor
        public CambioEstado(DateTime fechaHoraInicio, Estado estado)
        {
            this.fechaHoraInicio = fechaHoraInicio;
            this.estado = estado;
        }
        public CambioEstado()
        {
            
            this.fechaHoraInicio = DateTime.Now;
            this.estado = new Estado();
        }

        //Metodo que verifica si el estado es Iniciado
        public bool esEstadoInicial() {
            bool result = false;
            if (this.estado.esIniciada())
            {
                result = true;
            }
            return result;
        }
        //Metodo que devuelve true si es el ultimo estado TERMINAR
        public bool esUltimoEstado() {
            return false;
        }
       
       

    }
}
