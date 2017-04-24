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
        private Coluna ativo;
        private EnumEstadoRegistro estadoRegistro;
        private string comandoSelect;
        private string comandoInsert;
        private string comandoUpdate;
        private string comandoDelete;

        public string NomeTabela { get { return nomeTabela; } set { nomeTabela = value; } }
        public int Codigo { get { return Convert.ToInt32(codigo.Valor); } set { codigo.Valor = Convert.ToInt32(value); } }
        public int Sequencia { get { return Convert.ToInt32(sequencia.Valor); } set { sequencia.Valor = Convert.ToInt32(value); } }
        public int CodigoEntidade { get { return Convert.ToInt32(codigoEntidade.Valor); } set { codigoEntidade.Valor = Convert.ToInt32(value); } }
        public DateTime DataCadastro { get { return Convert.ToDateTime(dataCadastro.Valor); } set { dataCadastro.Valor = Convert.ToDateTime(value); } }
        public bool Ativo { get { return Convert.ToBoolean(ativo.Valor); } set { ativo.Valor = Convert.ToBoolean(value); } }

        public EnumEstadoRegistro EstadoRegisro { get { return estadoRegistro; } set { estadoRegistro = value; } }

        public string ComandoSelect { get { return comandoSelect; } set { comandoSelect = value; } }
        public string ComandoInsert { get { return comandoInsert; } set { comandoInsert = value; } }
        public string ComandoUpdate { get { return comandoUpdate; } set { comandoUpdate = value; } }
        public string ComandoDelete { get { return comandoDelete; } set { comandoDelete = value; } }

        public enum EnumEstadoRegistro
        {
            Carregado,
            Inserido,
            Atualizado,
            Deletado,
        }

        public Tabela()
        {
            codigo = new Modelo.Coluna("Codigo");
            sequencia = new Coluna("Sequencia");
            codigoEntidade = new Coluna("CodigoEntidade");
            dataCadastro = new Coluna("DataCadastro");
            ativo = new Modelo.Coluna("Ativo");

            sequencia.AceitaNulo = false;
            codigoEntidade.AceitaNulo = false;
            dataCadastro.ValorPadrao = "GETDATE()";
        }
    }
}
