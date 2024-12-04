using NomeSobreNomeAPP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatanbezerradasilvaClass
{
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void txtNomecli_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new(
                txtNomecli.Text,
                txtEmail.Text,
                txtEndereço.Text,
                Cliente.ObterClienteporID(convert(txtNomecli.Text)
                ));

        }
    }
}
