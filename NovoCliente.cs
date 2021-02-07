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
    public partial class NovoCliente : Form
    {
        public NovoCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void salvar_cliente_Click(object sender, EventArgs e)
        {
            String nome = nome_cliente.Text;
            String cpj_cnpj = cpf_cnpj_cliente.Text;
            String telefone = telefone_cliente.Text;
            String endereco = endereco_cliente.Text;

            Cliente cli = new Cliente();
            cli.SetNome(nome);
            cli.SetCpfCnpj(cpj_cnpj);
            cli.SetTelefone(telefone);
            cli.SetEndereco(endereco);

            DadosArmazenados.clientes.Add(cli);

            this.Close();
        }

        private void NovoCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
