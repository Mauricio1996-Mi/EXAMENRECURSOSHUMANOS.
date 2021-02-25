using System;
using System.Collections.Generic;
using System.Text;

namespace clases1
{
    public class cliente:persona
    {
        //atributos
        private string categoria;
        private string codigopedido;

        //propiedades
        public string Categoria { get => categoria; set => categoria = value; }
        public string Cogigopedido { get => codigopedido; set => codigopedido = value; }
        // procedimiento, operaciones o metodos

        public void generarcodigopedido ()
        {
            this.codigopedido = "c" + this.Appaterno.Substring(0, 3);
        }
    }
}
