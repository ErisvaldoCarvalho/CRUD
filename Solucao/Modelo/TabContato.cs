using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Modelo
{
    public partial class TabContato
    {
        private bool inserido;
        private bool editado;
        private int codigo;
        private int codigoCliente;
        private string contato;
        private string tipo;
        private DateTime dataCadastro;

        [Browsable(false)]
        public bool Inserido { get { return inserido; } }

        [Browsable(false)]
        public bool Editado { get { return editado; } }

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public int CodigoCliente { get { return codigoCliente; } set { codigoCliente = value; } }
        public string Tipo { get { return tipo; } set { tipo = value; } }
        public string Contato { get { return contato; } set { contato = value; } }
        public DateTime DataCadastro { get { return dataCadastro; } set { dataCadastro = value; } }
    }
}
