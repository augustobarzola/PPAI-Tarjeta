using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAI_Tarjeta.Modelo
{
    public class Cliente
    {
        private int dni;
        private string nombreCompleto;
        private int nroCelular;

        //Metodos de seteo
        public void setDni(int dni)
        {
            this.dni = dni;
        }
        public int getDni()
        {
            return this.dni;
        }

        public void setNombreCompleto(string nombreCompleto)
        {
            this.nombreCompleto = nombreCompleto;
        }
        public string getNombreCompleto()
        {
            return this.nombreCompleto;
        }
        public void setNroCelular(int nroCelular)
        {
            this.nroCelular = nroCelular;
        }
        public int getNroCelular()
        {
            return this.nroCelular;
        }


        //Constructor
        public Cliente(int dni, string nombreCompleto, int nroCelular)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.nroCelular = nroCelular;
        }
        public Cliente()
        {
            this.dni = 0;
            this.nombreCompleto = "";
            this.nroCelular = 0;
        }

    }
}
