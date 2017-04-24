using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class Tabela
    {
        private string nomeTabela;
        private Coluna codigo;
        private Coluna sequencia;
        private Coluna codigoEntidade;
        private Coluna dataCadastro;

        public string NomeTabela { get { return nomeTabela; } set { nomeTabela = value; } }
        public int Codigo { get { return Convert.ToInt32(codigo.Valor); } set { codigo.Valor = Convert.ToInt32(value); } }
        public int Sequencia { get { return Convert.ToInt32(sequencia.Valor); } set { sequencia.Valor = Convert.ToInt32(value); } }
        public int CodigoEntidade { get { return Convert.ToInt32(codigoEntidade.Valor); } set { codigoEntidade.Valor = Convert.ToInt32(value); } }
        public DateTime DataCadastro { get { return Convert.ToDateTime(dataCadastro.Valor); } set { dataCadastro.Valor = Convert.ToDateTime(value); } }

        public Tabela()
        {
            codigo = new Modelo.Coluna();
            sequencia = new Coluna();
            codigoEntidade = new Coluna();
            dataCadastro = new Coluna();
            
            codigo.NomeColuna = "Codigo";
            sequencia.NomeColuna = "Sequencia";
            sequencia.AceitaNulo = false;
            codigoEntidade.NomeColuna = "CodigoEntidade";
            codigoEntidade.AceitaNulo = false;
            dataCadastro.NomeColuna = "DataCadastro";
            dataCadastro.ValorPadrao = "GETDATE()";
            

        }
    }
}
