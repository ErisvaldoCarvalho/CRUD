using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class TabProduto : Tabela
    {
        private Coluna nome;
        private Coluna unidade;

        public string Nome { get { return nome.Valor.ToString(); } set { nome.Valor = value.ToString(); } }
        public string Unidade { get { return unidade.Valor.ToString(); } set { unidade.Valor = value.ToString(); } }

        public TabProduto()
        {
            this.NomeTabela = "Produto";
            nome = new Coluna("Nome");
            unidade = new Coluna("Unidade");

            this.ComandoSelect = "SELECT Codigo, Sequencia, CodigoEntidade, Nome, Unidade, DataCadastro, Ativo FROM Produto";
            this.ComandoInsert = "INSERT INTO Produto(Codigo, Sequencia, CodigoEntidade, Nome, Unidade, DataCadastro, Ativo) VALUES(@Codigo, @Sequencia, @CodigoEntidade, @Nome, @Unidade, @DataCadastro, @Ativo)";
            this.ComandoDelete = "DELETE FROM Produto WHERE Codigo = @Codigo";
            this.ComandoUpdate = "UPDATE Produto SET Codigo = @Codigo, Sequencia = @Sequencia, CodigoEntidade = @CodigoEntidade, Nome = @Nome, Unidade = @Unidade, DataCadastro = @DataCadastro, Ativo = @Ativo WHERE Codigo = @Codigo";
        }
    }
}
