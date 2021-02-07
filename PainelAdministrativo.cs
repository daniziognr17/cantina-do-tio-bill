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
    public partial class PainelAdministrativo : Form
    {
        public PainelAdministrativo()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PainelAdministrativo_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovoCliente novoCli = new NovoCliente();
            novoCli.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExcluirCliente excluirCli = new ExcluirCliente();
            excluirCli.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RelatorioCliente relCli = new RelatorioCliente();
            relCli.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NovaQuentinha novaQuent = new NovaQuentinha();
            novaQuent.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ExcluirQuentinha excluirQuent = new ExcluirQuentinha();
            excluirQuent.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RelatorioPedidos relPedidos = new RelatorioPedidos();
            relPedidos.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RelatorioQuentinhas relQuentinhas = new RelatorioQuentinhas();
            relQuentinhas.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RelatorioFinancas relFina = new RelatorioFinancas();
            relFina.ShowDialog();
        }
    }
}
