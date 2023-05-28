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
        public CategoriaLlamada()
        {
            this.audioMensajeOpciones = "";
            this.mensajeOpciones = 0;
            this.nombre = "";
            this.nroOrden = 0;
            this.opcion = new List<OpcionLlamada>();
        }

        //metodo que devuelve informacion de la categoria dada su opcion y subopcion 
         public CategoriaLlamada getDatosCategoriaLlamada(OpcionLlamada op)
        {
            CategoriaLlamada categoria=new CategoriaLlamada();
            foreach (OpcionLlamada var in opcion) {
                if (var.getNombre()==op.getNombre()  )
                {
                     categoria = new CategoriaLlamada(getAudioMensajeOpciones(), getMensajeOpciones(), getNombre(), getNroOrden(), this.opcion);

                }
            }
            return categoria;
        }
        //metodo que busca las validaciones correspondiente a la opcion y subopcion seleccionadas
        public List<Validacion> buscarValidaciones(OpcionLlamada opcion)
        {
            List<Validacion> lista = new List<Validacion>();
            lista=opcion.getSubOpcionLlamada()[0].buscarValidaciones();
            return lista;
        }
    }
}
