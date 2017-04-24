using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelo
{
    public class TabCategoriaProduto: Tabela
    {
        private Coluna nome;

        public string Nome { get { return nome.Valor.ToString(); } set { nome.Valor = value.ToString(); } }

        public TabCategoriaProduto()
        {
            this.NomeTabela = "CategoriaProduto";
            nome = new Coluna("Nome");

            this.ComandoSelect = "SELECT Codigo, Sequencia, CodigoEntidade, Nome, DataCadastro, Ativo FROM Produto";
            this.ComandoInsert = "INSERT INTO CategoriaProduto(Codigo, Sequencia, CodigoEntidade, Nome, DataCadastro, Ativo) VALUES(@Codigo, @Sequencia, @CodigoEntidade, @Nome, @DataCadastro, @Ativo)";
            this.ComandoDelete = "DELETE FROM CategoriaProduto WHERE Codigo = @Codigo";
            this.ComandoUpdate = "UPDATE CategoriaProduto SET Codigo = @Codigo, Sequencia = @Sequencia, CodigoEntidade = @CodigoEntidade, Nome = @Nome, DataCadastro = @DataCadastro, Ativo = @Ativo WHERE Codigo = @Codigo";
        }
    }
}
