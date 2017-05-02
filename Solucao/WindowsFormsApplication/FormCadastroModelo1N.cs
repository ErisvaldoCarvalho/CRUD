using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace WindowsFormsApplication
{
    public partial class FormCadastroModelo1N : Form
    {
        public BindingSource dados;
        private string titulo;
        ITab tab;

        public FormCadastroModelo1N()
        {
            InitializeComponent();
        }

        private void buttonGravarEContinuar_Click(object sender, EventArgs e)
        {
            Gravar();
            this.Close();
        }

        private void Gravar()
        {
            ((ITab)dados.Current).Gravar();
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Gravar();
            dados.DataSource = new BindingList<ITab>(tab.Novo());
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            ((ITab)dados.Current).Excluir();
            dados.RemoveCurrent();
            this.Close();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
