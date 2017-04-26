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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (FormConsultaModelo frm = new WindowsFormsApplication.FormConsultaModelo())
            {
                Modelo.TabCliente cliente = new Modelo.TabCliente();
                frm.dados.DataSource = new BindingList<TabCliente>(TabCliente.BuscarTodos());
                frm.Text = "Cadastro de clientes";
                frm.ShowDialog();
            }
        }
    }
}
