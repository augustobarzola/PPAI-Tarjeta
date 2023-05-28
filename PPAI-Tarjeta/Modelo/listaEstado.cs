using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
    //Esta clase fue creada con el proposito de probar como funciona el programa,
    //en el programa finalizado se va a buscar de la bd
    public class listaEstado
    {
        private List<Estado> listaEstados;

        public listaEstado() {
            Estado estadoIniciado = new Estado("Iniciada");
            Estado estadoFinal = new Estado("Finalizado");
            Estado estadoEnCurso = new Estado("En Curso");

            this.listaEstados = new List<Estado>() {
            estadoIniciado,estadoEnCurso,estadoFinal
            };
        }
        public List<Estado> getListaEstado() {
            return this.listaEstados;
        }
        
    }
}
