using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelo;

namespace WindowsFormsApplication
{
    public partial class FormCadastroModelo : Form
    {
        public BindingSource dados;
        private string titulo;
        ITab tab;

        public FormCadastroModelo(ITab _tab)
        {
            InitializeComponent();
            tab = _tab;
        }

        private void FormCadastroModelo_Load(object sender, EventArgs e)
        {
            label1.Text = this.Text;
        }

        private void buttonGravar_Click(object sender, EventArgs e)
        {
            Gravar();
            this.Close();
        }

        private void Gravar()
        {
            ((ITab)dados.Current).Gravar();
        }

        private void buttonGravarEContinuar_Click(object sender, EventArgs e)
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
    }
}
