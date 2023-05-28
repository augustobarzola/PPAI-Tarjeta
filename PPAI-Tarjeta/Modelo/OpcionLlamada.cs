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
        public void setSubOpcionLlamada(List<SubOpcionLlamada> lista)
        {
            this.subopcionLlamada = lista;
        }
        public List<SubOpcionLlamada> getSubOpcionLlamada()
        {
            return this.subopcionLlamada;
        }
         //El constructor
       
        public OpcionLlamada(string audioMensajeSubopciones, int mensajeSubopciones, string nombre, int nroOrden, List<SubOpcionLlamada> subOpcionLlamada)
        {
            this.audioMensajeSubopciones = audioMensajeSubopciones;
            this.mensajeSubopciones = mensajeSubopciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.subopcionLlamada = subOpcionLlamada;
        }
        public OpcionLlamada()
        {
            this.audioMensajeSubopciones = "";
            this.mensajeSubopciones = 0;
            this.nombre = "";
            this.nroOrden = 0;
            this.subopcionLlamada = null;
        }
        //Metodo que devuelve todos los nombres de las subopciones (no estoy seguro si devuelve solo el nombre o toda la opcion)
        public string getDatosOpcionSeleccionada(SubOpcionLlamada subop)
        {
            string retorno = "";
            foreach (SubOpcionLlamada sub in subopcionLlamada) {
                if (sub.getNombre() == subop.getNombre()) {
                    retorno = getNombre();
                }
            }

            return retorno;
        }

        //metodo que devuelve las validacion de la opcion
        public List<Validacion> buscarValidaciones(SubOpcionLlamada sub) {
            List<Validacion> lista = new List<Validacion>();
            lista=sub.buscarValidaciones();
            return lista;
        }

    }
}
