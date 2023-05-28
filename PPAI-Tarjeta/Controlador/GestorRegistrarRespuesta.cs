using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Controlador
{
    public class GestorRegistrarRespuesta
    {
        private Modelo.Llamada llamadaCliente;
        private Modelo.Estado estadoEnCurso;
        private Modelo.Estado estadoFinalizado;
        private Modelo.CategoriaLlamada categoria=new Modelo.CategoriaLlamada();
        private Vista.PantallaRegistrarRespuesta pantallaRegistrarRespuesta;
        private Modelo.listaEstado listaEstado;
        //Metodos de seteo
        public void setLlamada(Modelo.Llamada llamada)
        {
            this.llamadaCliente = llamada;
        }
        public Modelo.Llamada getLlamada()
        {
            return this.llamadaCliente;
        }

        public void setEstadoEncurso(Modelo.Estado estado)
        {
            this.estadoEnCurso = estado;
        }
        public Modelo.Estado getEstado()
        {
            return this.estadoEnCurso;
        }
        //Constructor del gestor que recibe una pantalla
        public GestorRegistrarRespuesta(Modelo.Llamada llamada, Vista.PantallaRegistrarRespuesta pantalla) {
            
            this.pantallaRegistrarRespuesta = new Vista.PantallaRegistrarRespuesta(this);
            this.recibirLlamada(llamada);
            //Creo una lista de estados y busco el enCurso (en el programa se buscaria en la bd)
            listaEstado = new Modelo.listaEstado();
            this.buscarEstadoEncurso(listaEstado.getListaEstado());
            //Creo el nuevo cambio de estado a en curso
            //Lo seteo a hace 5 min para que se pueda notar mejor la diferencia
            DateTime fechaInicio = DateTime.Now - new TimeSpan(0, 5, 0);
            this.llamadaCliente.nuevaLlamadaIniciada(estadoEnCurso, fechaInicio);
            List<Modelo.Validacion> listadoValidacion=new List<Modelo.Validacion>();
            listadoValidacion = this.buscarValidacion();
            Modelo.listaCategoria listaCat = new Modelo.listaCategoria();
            foreach (Modelo.CategoriaLlamada catego in listaCat.GetCategoriaLlamada()) {
              this.categoria=catego.getDatosCategoriaLlamada(this.getLlamada().getOpcionLlamada());
            }
            
            this.mostrarDatosOpSubopCatVal(listadoValidacion);
            this.pantallaRegistrarRespuesta.ShowDialog();
        }
        //Metodo que recibe datos de la llamada y los guarda
        public void recibirLlamada(Modelo.Llamada llamada) {
            this.llamadaCliente = llamada;
        }

        //Metodo que busca todos los estados y guarda el en curso
        //lo tiene que buscar de la BD pero ahora lo vamos a buscar de otra clase
        public void buscarEstadoEncurso(List<Modelo.Estado> listaEstado) {
            foreach (Modelo.Estado estado in listaEstado) {
                if (estado.esIniciada()) {
                    estadoEnCurso = estado;
                }
            }
            
        }
        //Metodo que devuelve la validacion correspondiente a la subopcionseleccionada, de la opcion seleccionada 
        public List<Modelo.Validacion> buscarValidacion() {
            List<Modelo.Validacion> validacion=new List<Modelo.Validacion>();
            validacion=categoria.buscarValidaciones(llamadaCliente.getOpcionLlamada());
            return validacion;
            
        }
        //Busca el nombre del cliente actual??
        public string obtenerDatosLlamada() {
            string nombre="";
            nombre = this.llamadaCliente.getNombreClienteActual();
            return nombre;
        }
        //No se a que se refiere con asignar operador
        public void asignarOperador() { 
       // llamadaCliente.
        }
        //Muestra todas las validaciones por pantalla
        public void mostrarDatosOpSubopCatVal(List<Modelo.Validacion> valida) {
            this.pantallaRegistrarRespuesta.setCategoria(categoria.getNombre());
            this.pantallaRegistrarRespuesta.setOpcion(llamadaCliente.getOpcionLlamada().getNombre());
           this.pantallaRegistrarRespuesta.setSubOpcion(llamadaCliente.getSubOpcionLlamada().getNombre());
            this.pantallaRegistrarRespuesta.setCliente(llamadaCliente.getCliente().getNombreCompleto());
            this.pantallaRegistrarRespuesta.setGridRow(valida);
           
        }

        //Validar respuestas recibidas por la pantalla con las del valor correcto
        public bool validarRespuesta(string nomValid, string op) {
            bool retorno = false;
            if (llamadaCliente.getCliente().validarRespuesta(nomValid, op)) {
                retorno = true;
            }
            return retorno;
        }
        //registrar la accion requerida?? No estoy seguro de que significa eso
        public void registrarAccionRequerida() {
            //Algo va a hacer, le manda un mje a otro caso de uso
            informarEjecucionCU();
        }
        public void informarEjecucionCU() {
            this.pantallaRegistrarRespuesta.informarEjecucionCU();
            this.finalizarLlamada();
        }
        public void finalizarLlamada() {
            DateTime FechaYHoraActual=this.getFechaYHoraActual();
            this.buscarEstadoFinalizado(listaEstado.getListaEstado());
            this.llamadaCliente.nuevaLlamadaFinalizada(this.estadoFinalizado,FechaYHoraActual);
        }
        public DateTime getFechaYHoraActual() {
            DateTime fecha = DateTime.Now;
            return fecha;

        }
        //Busco estad finalizado
        public void buscarEstadoFinalizado(List<Modelo.Estado> listaEstado)
        {
            foreach (Modelo.Estado estado in listaEstado)
            {
                if (estado.esFinalizado())
                {
                    estadoFinalizado = estado;
                }
            }

        }
    }
}
