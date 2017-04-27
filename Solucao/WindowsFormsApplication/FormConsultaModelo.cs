using Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class FormConsultaModelo : Form
    {
        public BindingSource dados;
        ITab tab;

        public FormConsultaModelo(ITab _tab)
        {
            InitializeComponent();
            dados = new BindingSource();
            tab = _tab;
            dados.DataSource = new BindingList<ITab>(tab.BuscarTodos());
            dataGridViewDados.DataSource = dados;
        }
                        
        private void FormConsultaModelo_Load(object sender, EventArgs e)
        {
            labelTitulo.Text = this.Text;
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            
            bs.DataSource = new BindingList<ITab>(tab.Novo());

            using (FormCadastroModelo frm = new FormCadastroModelo(tab))
            {
                frm.Text = this.Text;
                frm.textBoxCodigo.DataBindings.Add("Text", bs, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxNome.DataBindings.Add("Text", bs, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxDataCadastro.DataBindings.Add("Text", bs, "DataCadastro", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.dados = bs;
                frm.ShowDialog();
            }
            dados.DataSource = new BindingList<ITab>(tab.BuscarTodos());
            dados.MoveLast();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroModelo frm = new FormCadastroModelo(tab))
            {
                frm.dados = dados;
                frm.Text = this.Text;
                frm.textBoxCodigo.DataBindings.Add("Text", dados, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxNome.DataBindings.Add("Text", dados, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxDataCadastro.DataBindings.Add("Text", dados, "DataCadastro", true, DataSourceUpdateMode.OnPropertyChanged);

                frm.ShowDialog();
            }
            dados.DataSource = new BindingList<ITab>(tab.BuscarTodos());
            dados.MoveLast();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            using (FormCadastroModelo frm = new FormCadastroModelo(tab))
            {
                frm.dados = dados;
                frm.Text = this.Text;
                frm.textBoxCodigo.DataBindings.Add("Text", dados, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxNome.DataBindings.Add("Text", dados, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxDataCadastro.DataBindings.Add("Text", dados, "DataCadastro", true, DataSourceUpdateMode.OnPropertyChanged);
                
                frm.ShowDialog();
            }
            dados.DataSource = new BindingList<ITab>(tab.BuscarTodos());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewDados.DataSource = dados;
            dataGridViewDados.RefreshEdit();
        }
    }
}
