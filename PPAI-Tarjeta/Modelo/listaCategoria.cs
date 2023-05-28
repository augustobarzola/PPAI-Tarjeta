using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
    //Esta clase fue creada con el proposito de probar como funciona el programa,
    //en el programa finalizado se va a buscar de la bd
    public class listaCategoria
    {
        private List<CategoriaLlamada> listaCat;

        public listaCategoria() {
            
            SubOpcionLlamada sub1 = new SubOpcionLlamada("Tengo las datos de la tarjeta",1);
            SubOpcionLlamada sub2 = new SubOpcionLlamada("No tengo datos de tarjeta",2);
            SubOpcionLlamada sub3 = new SubOpcionLlamada("Quiero hablar con responsable",3);
            SubOpcionLlamada sub4 = new SubOpcionLlamada("Quiero finalizar llamada",4);
            List<SubOpcionLlamada> listaSub = new List<SubOpcionLlamada> { sub1, sub2, sub3, sub4 };
            OpcionLlamada op1 = new OpcionLlamada("Si desea informar un robo y solicitar nueva tarjeta", 1, "Nueva Tarjeta", 1, listaSub);
            OpcionLlamada op2 = new OpcionLlamada("Si desea anular la tarjeta robada", 2, "Anular Tarjeta", 2, listaSub);
            List<OpcionLlamada> listaOpcion=new List<OpcionLlamada> { op1, op2};
            CategoriaLlamada cat1=new CategoriaLlamada("Si desea denunciar el robo",1,"Robo",1,listaOpcion);
            this.listaCat = new List<CategoriaLlamada>() { cat1 };
        }
        public List<CategoriaLlamada> GetCategoriaLlamada() {
            return this.listaCat;
        }
    }
}
