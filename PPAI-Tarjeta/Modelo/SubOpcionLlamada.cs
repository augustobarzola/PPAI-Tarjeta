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
        public SubOpcionLlamada(string nombre, int nroOrden)
        {
            this.nombre = nombre;
            this.nroOrden = nroOrden;
           
        }

        public bool esNro(int numero) {
            bool flag = false;
            if (this.nroOrden == numero) {
                flag = true;
            }
            return flag;
        }

        //Metodo que busca todas las validaciones de la subopcion seleccionada, va a devolver de 0 a * validaciones
        public List<Validacion> buscarValidaciones() {
            List<Validacion> valida = new List<Validacion>();
            if (this.validacionRequerida == null)
            {
                //le invento una validacion si esta nula, normalmente no va a pasar esto
                //pero en mi ejemplo si porque no lo estoy buscando de la bd
                OpcionValidacion op1 = new OpcionValidacion(false, "25/07/2001");
                OpcionValidacion op2 = new OpcionValidacion(true, "07/02/2004");
                OpcionValidacion op3 = new OpcionValidacion(false, "15/09/2003");
                OpcionValidacion op4 = new OpcionValidacion(true, "5000");
                OpcionValidacion op5 = new OpcionValidacion(false, "4955");
               
                Validacion val1 = new Validacion("Ingrese la fecha de nacimiento", "Fecha de nacimiento", new List<OpcionValidacion>() { op1, op2, op3 });
                Validacion val2 = new Validacion("Ingrese el codigo postal", "Codigo Postal", new List<OpcionValidacion>() { op4, op5});
                valida.Add(val1);
                valida.Add(val2);
            }
            else
            {
                foreach (Validacion val in this.validacionRequerida)
                {
                   
                }
            }
            return valida;
        }


    }
}
