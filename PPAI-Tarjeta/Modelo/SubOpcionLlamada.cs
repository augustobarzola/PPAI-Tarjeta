using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
    public class SubOpcionLlamada
    {
        private string nombre;
        private int nroOrden;
        private List<Validacion> validacionRequerida;

        //Metodos de seteo
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
        public List<Validacion> validaciones { get => validacionRequerida; set => validacionRequerida = value; }
        //Constructor
        public SubOpcionLlamada(string nombre, int nroOrden, List<Validacion>validacionRequerida)
        {
            this.nombre = nombre;
            this.nroOrden = nroOrden;
            this.validacionRequerida = validacionRequerida;
        }
        

        public bool esNro(int numero) {
            bool flag = false;
            if (this.nroOrden == numero) {
                flag = true;
            }
            return flag;
        }




    }
}
