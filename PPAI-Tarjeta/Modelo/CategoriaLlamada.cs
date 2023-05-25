using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
    public class CategoriaLlamada
    {
        private string audioMensajeOpciones;
        private int mensajeOpciones;
        private string nombre;
        private int nroOrden;
        private List<OpcionLlamada> opcion;


        //Creamos los metodos de seteo;
        public void setAudioMensajeOpciones(string audioMensajeOpciones) {
            this.audioMensajeOpciones = audioMensajeOpciones;
        }
        public string getAudioMensajeOpciones() {
            return this.audioMensajeOpciones;
        }
        public void setMensajeOpciones(int mensajeOpciones)
        {
            this.mensajeOpciones = mensajeOpciones;
        }
        public int getMensajeOpciones()
        {
            return this.mensajeOpciones;
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
        public List<OpcionLlamada> opciones { get => opcion; set => opcion = value; }

        //Constructor
       
        public CategoriaLlamada(string audioMensajeOpciones, int mensajeOpciones, string nombre, int nroOrden, List<OpcionLlamada> opcion)
        {
            this.audioMensajeOpciones = audioMensajeOpciones;
            this.mensajeOpciones = mensajeOpciones;
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.opcion = opcion;
        }

        //metodo que devuelve todos los datos
        public CategoriaLlamada getDatosCategoriaLlamada()
        {
            CategoriaLlamada categoria = new CategoriaLlamada(this.getAudioMensajeOpciones(), this.getMensajeOpciones(), this.getNombre(), this.getNroOrden(), this.opcion);
            return categoria;
        }

    }
}
