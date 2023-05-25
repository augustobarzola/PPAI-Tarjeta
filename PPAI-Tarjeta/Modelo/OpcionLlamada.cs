using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
    public class OpcionLlamada
    {
        private string audioMensajeSubopciones;
        private int mensajeSubopciones;
        private string nombre;
        private int nroOrden;
        private List<SubOpcionLlamada> subopcionLlamada;

        //Creamos metodos de seteo
        public void setAudioMensajeSubopciones(string audioMensajeSubopciones)
        {
            this.audioMensajeSubopciones = audioMensajeSubopciones;
        }
        public string getAudioMensajeSubopciones()
        {
            return this.audioMensajeSubopciones;
        }
        public void setMensajeSubopciones(int mensajeSubopciones)
        {
            this.mensajeSubopciones = mensajeSubopciones;
        }
        public int getMensajeSubopciones()
        {
            return this.mensajeSubopciones;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }

        public void setNroOrden(int nroOrden)
        {
            this.nroOrden = nroOrden;
        }
        public int getNroOrden()
        {
            return this.nroOrden;
        }
        public List<SubOpcionLlamada> subopcion { get => subopcionLlamada; set => subopcionLlamada = value; }
        //El constructor
       
        public OpcionLlamada(string audioMensajeSubopciones, int mensajeSubopciones, string nombre, int nroOrden, List<SubOpcionLlamada> subOpcionLlamada)
        {
            this.audioMensajeSubopciones = audioMensajeSubopciones;
            this.mensajeSubopciones = mensajeSubopciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.subopcionLlamada = subOpcionLlamada;
        }

        //Metodo que devuelve todos los datos
        public OpcionLlamada getDatosOpcionSeleccionada() {
            OpcionLlamada opcion = new OpcionLlamada(this.getAudioMensajeSubopciones(), this.getMensajeSubopciones(), this.getNombre(), this.getNroOrden(),this.subopcionLlamada);
            return opcion;
        }

    }
}
