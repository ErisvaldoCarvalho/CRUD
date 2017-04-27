using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public interface ITab
    {
        List<ITab> Novo();

        Int32 Incrementa();

        List<ITab> BuscarTodos();

        void Inserir();

        void Atualizar();

        void Excluir();

        void Gravar();
            
        int Codigo { get; set; }
        string Nome { get; set; }
        DateTime DataCadastro { get; set; }
        List<TabContato> Contatos { get; set; }
    }
}
