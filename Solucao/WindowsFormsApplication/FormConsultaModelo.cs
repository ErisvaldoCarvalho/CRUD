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

        public FormConsultaModelo()
        {
            InitializeComponent();
            dados = new BindingSource();
        }

        //public FormConsultaModelo(BindingSource _dados, string _titulo)
        //{
        //    InitializeComponent();
        //    dados = _dados;
        //    dataGridViewDados.DataSource = dados;

        //    this.Text = _titulo;
        //    this.labelTitulo.Text = _titulo;
        //}

        //public FormConsultaModelo(BindingSource _dados, Form _formCadastro)
        //{
        //    InitializeComponent();

        //    formCadastro = _formCadastro;
        //    this.Text = formCadastro.Text;
        //    this.labelTitulo.Text = formCadastro.Text;
        //}



        private void FormConsultaModelo_Load(object sender, EventArgs e)
        {
            labelTitulo.Text = this.Text;
            dataGridViewDados.DataSource = dados;
        }

        private void novoButton_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = new BindingList<TabCliente>(TabCliente.Novo());

            using (FormCadastroModelo frm = new FormCadastroModelo())
            {
                frm.Text = this.Text;
                frm.textBoxCodigo.DataBindings.Add("Text", bs, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxNome.DataBindings.Add("Text", bs, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxDataCadastro.DataBindings.Add("Text", bs, "DataCadastro", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.dados = bs;
                frm.ShowDialog();
            }
            dados.DataSource = new BindingList<TabCliente>(TabCliente.BuscarTodos());
            dados.MoveLast();
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroModelo frm = new FormCadastroModelo())
            {
                frm.dados = dados;
                frm.Text = this.Text;
                frm.textBoxCodigo.DataBindings.Add("Text", dados, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxNome.DataBindings.Add("Text", dados, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxDataCadastro.DataBindings.Add("Text", dados, "DataCadastro", true, DataSourceUpdateMode.OnPropertyChanged);

                frm.ShowDialog();
            }
            dados.DataSource = new BindingList<TabCliente>(TabCliente.BuscarTodos());
            dados.MoveLast();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            using (FormCadastroModelo frm = new FormCadastroModelo())
            {
                frm.dados = dados;
                frm.Text = this.Text;
                frm.textBoxCodigo.DataBindings.Add("Text", dados, "Codigo", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxNome.DataBindings.Add("Text", dados, "Nome", true, DataSourceUpdateMode.OnPropertyChanged);
                frm.textBoxDataCadastro.DataBindings.Add("Text", dados, "DataCadastro", true, DataSourceUpdateMode.OnPropertyChanged);
                
                frm.ShowDialog();
            }
            dados.DataSource = new BindingList<TabCliente>(TabCliente.BuscarTodos());
        }
    }
}
