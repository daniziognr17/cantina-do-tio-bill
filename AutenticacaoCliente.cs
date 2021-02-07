using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cantinha_do_tio_bill
{
    public partial class AutenticacaoCliente : Form
    {
        public AutenticacaoCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(var item in DadosArmazenados.clientes)
            {
                if (input_cpf.Text == item.GetCpfCnpj())
                {
                    DadosArmazenados.usuarioLogado = item;
                    PainelCliente pCliente = new PainelCliente();
                    pCliente.ShowDialog();
                    this.Close();
                } else
                {
                    mensagem_autenticacao.Text = "CPF ou CNPJ não constam na base de dados!";
                }
            }
        }
    }
}
