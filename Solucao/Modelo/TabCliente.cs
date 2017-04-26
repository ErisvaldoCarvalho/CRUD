using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Modelo
{
    public partial class TabCliente : IDisposable
    {
        private bool inserido;
        private bool editado;
        private int codigo;
        private string nome;
        private DateTime dataCadastro;


        [Browsable(false)]
        public bool Inserido { get { return inserido; } }

        [Browsable(false)]
        public bool Editado { get { return editado; } }

        public int Codigo { get { return codigo; } set { codigo = value; } }
        public string Nome { get { return nome; } set { nome = value; editado = true; } }
        public DateTime DataCadastro { get { return dataCadastro; } set { dataCadastro = value; } }
        public List<TabContato> Contatos { get; set; }


    }
}
