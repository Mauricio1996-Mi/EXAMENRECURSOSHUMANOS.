using System;
using System.Collections.Generic;
using System.Text;

namespace clases1
{
    public class empleado:persona
    {
        //atributo
        private string tipo;
        private string tipocontrato;
        private double sueldo;

        //propiedades
        public string Tipo { get => tipo; set => tipo = value; }
        public string Tipocontrato { get => tipocontrato; set => tipocontrato = value; }
        public double Suedo { get => sueldo; set => sueldo = value; }
        //metodos o calculos
        public void calcularsueldo(double sueldoprincipal)
        {
            if (this.tipo== "gerente")
            {
                if (this.tipocontrato =="nuevo")
                {
                    sueldo = 2 * sueldoprincipal + 500;


                }
            }
            else if (tipo == "vendedor")
            {
                if (this.tipocontrato == "nuevo")
                {
                    sueldo = sueldoprincipal + 500;
                       }
                else if (this.tipocontrato == "longevo")
                {
                    sueldo = sueldoprincipal + 1500;
                }

            }
            else
            {
                this.sueldo = 0;
            }
        }
    }
}
