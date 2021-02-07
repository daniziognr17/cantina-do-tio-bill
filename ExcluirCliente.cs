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
    public partial class ExcluirCliente : Form
    {
        public ExcluirCliente()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ExcluirCliente_Load(object sender, EventArgs e)
        {
            foreach(var item in DadosArmazenados.clientes)
            {
                combo_clientes.Items.Add(item.GetNome() + " - " + item.GetCpfCnpj());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DadosArmazenados.clientes.RemoveAt(combo_clientes.SelectedIndex);
            this.Close();
        }
    }
}
