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
        private SubOpcionLlamada subOpcionSeleccionada;
        private int opcionSel;

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

        public void setCliente(Cliente cliente)
        {
            this.cliente = cliente;
        }
        public Cliente getCliente()
        {
            return this.cliente;
        }

        public void setOpcionLlamada(OpcionLlamada opcionLlamada)
        {
            this.opcionSeleccionada = opcionLlamada;
        }
        public OpcionLlamada getOpcionLlamada()
        {
            return this.opcionSeleccionada;
        }
        public void setSubOpcionLlamada(SubOpcionLlamada subOpcionLlamada)
        {
            this.subOpcionSeleccionada = subOpcionLlamada;
        }
        public SubOpcionLlamada getSubOpcionLlamada()
        {
            return this.subOpcionSeleccionada;
        }
        public void setCambioEstado(List<CambioEstado> cambioEstados)
        {
            this.cambioEstados = cambioEstados;
        }
        public List<CambioEstado> getCambioEstado()
        {
            return this.cambioEstados;
        }
       
     
        //Constructor
        public Llamada(string descripcionOperador, string detalleAccionRequerida, TimeSpan duracion, bool encuestaEnviada, string observacionAuditor, List<CambioEstado> cambioEstados, Cliente cliente, OpcionLlamada opcionSeleccionada, SubOpcionLlamada subOpcion)
        {
            this.descripcionOperador = descripcionOperador;
            this.detalleAccionRequerida = detalleAccionRequerida;
            this.duracion = duracion;
            this.encuestaEnviada = encuestaEnviada;
            this.observacionAuditor = observacionAuditor;
            this.cambioEstados = cambioEstados;
            this.cliente = cliente;
            this.opcionSeleccionada = opcionSeleccionada;
            this.subOpcionSeleccionada = subOpcion;
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

        public string getNombreClienteActual() {
            string nombre = "";
            nombre=cliente.getNombreCompleto();
            return nombre;
        }

        //Crea una nueva cambio de estado de iniciada
        public void nuevaLlamadaIniciada(Estado estado,DateTime fechaYHora) {
          
            CambioEstado iniciado = new CambioEstado(fechaYHora, estado);
            cambioEstados.Add(iniciado);
            
        }
        //Crea un nuevo cambio de estado finalizado
        public void nuevaLlamadaFinalizada(Estado estado,DateTime fechaYHora)
        {
            
            CambioEstado finalizado = new CambioEstado(fechaYHora, estado);
            cambioEstados.Add(finalizado);
            this.duracion = this.calcularDuracion2();
        }
        public TimeSpan calcularDuracion2() {
            TimeSpan duracion=new TimeSpan();
            DateTime fechaInicio = new DateTime();
            DateTime fechaFin = new DateTime();
            foreach(CambioEstado cambio in this.cambioEstados) {
                if (cambio.getEstado().esIniciada())
                {
                    fechaInicio = cambio.getFechaHoraInicio();
                }
                else
                    if (cambio.getEstado().esFinalizado()) {
                    fechaFin = cambio.getFechaHoraInicio();
                }

            }
            if (fechaInicio != new DateTime() && fechaFin != new DateTime()) {
                duracion = fechaFin - fechaInicio;
            }
            return duracion;
          }
    }
}
