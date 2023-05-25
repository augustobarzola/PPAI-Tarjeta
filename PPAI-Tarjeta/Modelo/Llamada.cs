using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
    public class Llamada
    {
        private string descripcionOperador;
        private string detalleAccionRequerida;
        private TimeSpan duracion;
        private bool encuestaEnviada;
        private string observacionAuditor;
        private List<CambioEstado> cambioEstados;
        private Cliente cliente;
        private OpcionLlamada opcionSeleccionada;

        //Metodos de seteo
        public void setDescripcionOperador(string descripcionOperador)
        {
            this.descripcionOperador = descripcionOperador;
        }
        public string getDescripcionOperador()
        {
            return this.descripcionOperador;
        }
        public void setDetalleAccionRequerida(string detalleAccionRequerida)
        {
            this.detalleAccionRequerida = detalleAccionRequerida;
        }
        public string getDetalleAccionRequerida()
        {
            return this.detalleAccionRequerida;
        }
        public void setDuracion(TimeSpan duracion)
        {
            this.duracion = duracion;
        }
        public TimeSpan getDuracion()
        {
            return this.duracion;
        }
        public void setEncuestaEnviada(bool encuestaEnviada)
        {
            this.encuestaEnviada = encuestaEnviada;
        }
        public bool getEncuestaEnviada()
        {
            return this.encuestaEnviada;
        }
        public void setObservacionAuditor(string observacionAuditor)
        {
            this.observacionAuditor = observacionAuditor;
        }
        public string getObservacionAuditor()
        {
            return this.observacionAuditor;
        }
        public List<CambioEstado> CambioEstado { get => cambioEstados; set => cambioEstados = value; }
        public Cliente clien { get => cliente; set => cliente = value; }
        public OpcionLlamada opLlamada { get => opcionSeleccionada; set => opcionSeleccionada = value; }
     
        //Constructor
        public Llamada(string descripcionOperador, string detalleAccionRequerida, TimeSpan duracion, bool encuestaEnviada, string observacionAuditor, List<CambioEstado> cambioEstados, Cliente cliente, OpcionLlamada opcionSeleccionada)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.cambioEstados = cambioEstados;
            this.cliente = cliente;
            this.opcionSeleccionada = opcionSeleccionada;
        }


        //Metodo que calcula la duracion de toda la llamada
        public TimeSpan calcularDuracion() {
            TimeSpan duracionLlamada=TimeSpan.Zero;
            TimeSpan inicioLlamada = TimeSpan.Zero;
            TimeSpan finLlamada = TimeSpan.Zero;
                foreach (var cambioEst in this.cambioEstados)
                {
                if (cambioEst.esEstadoInicial())
                {
                    inicioLlamada = cambioEst.getFechaHoraInicio().TimeOfDay;
                }
                else
                    if (cambioEst.esUltimoEstado()) {
                    finLlamada = cambioEst.getFechaHoraInicio().TimeOfDay;    
                }
                }
            if (inicioLlamada != TimeSpan.Zero && finLlamada != TimeSpan.Zero)
            {
                duracionLlamada = finLlamada - inicioLlamada;
            }
            return duracionLlamada;
        }

    }
}
