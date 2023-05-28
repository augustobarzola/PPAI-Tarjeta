using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
    public class Validacion
    {
        private string audioMensajeValidacion;
        private string nombre;
        private List<OpcionValidacion> opcionesValidacion;

        //Metodos de seteo
        public void setAudioMensajeValidacion(string audioMensajeValidacion)
        {
            this.audioMensajeValidacion = audioMensajeValidacion;
        }
        public string getAudioMensajeValidacion()
        {
            return this.audioMensajeValidacion;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string getNombre()
        {
            return this.nombre;
        }
        public List<OpcionValidacion> opciones { get => opcionesValidacion; set => opcionesValidacion = value; }
        //Constructor
        public Validacion(string audioMensajeValidacion, string nombre, List<OpcionValidacion> opcionValidaciones)
        {
            this.audioMensajeValidacion = audioMensajeValidacion;
            this.nombre = nombre;
            this.opcionesValidacion = opcionValidaciones;
        }
        public Validacion() {
            this.audioMensajeValidacion = "";
            this.nombre = "";
            this.opcionesValidacion = new List<OpcionValidacion>();
        }

        //Metodo que devuelve el nombre concatanada con el audio del mensaje de la validacion
        public string getMensajeValidacion() {
            string ret = "";
            ret = this.getNombre() + " " + this.getAudioMensajeValidacion();
            return ret;
        }
    }
}
