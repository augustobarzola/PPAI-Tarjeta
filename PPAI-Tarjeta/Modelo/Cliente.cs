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
        private List<InformacionCliente> informacionCliente;

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

        public void setInfoCliente(List<InformacionCliente> infoCliente)
        {
            this.informacionCliente = infoCliente;
        }
        public List<InformacionCliente> GetInformacionCliente()
        {
            return this.informacionCliente;
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
        public Cliente(int dni, string nombreCompleto, int nroCelular, List<InformacionCliente>info)
        {
            this.dni = dni;
            this.nombreCompleto = nombreCompleto;
            this.nroCelular = nroCelular;
            this.informacionCliente = info;
        }
        public Cliente()
        {
            this.dni = 0;
            this.nombreCompleto = "";
            this.nroCelular = 0;
        }

        //Metodo que valida que el cliente reciba una validacion
        public bool validarRespuesta(string nom,string op) {
            bool retorno = false;
            foreach ( InformacionCliente info in informacionCliente) {
                if (info.esValidacion(nom) &&
                info.esInformacionCorrecta(op))
                    retorno = true;
            }
            return retorno;
        }

    }
}
