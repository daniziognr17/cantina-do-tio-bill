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
    public partial class PainelCliente : Form
    {
        public PainelCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NovoPedido nPedido = new NovoPedido();
            nPedido.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientePedidos cPedidos = new ClientePedidos();
            cPedidos.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CancelarPedido cancelPedido = new CancelarPedido();
            cancelPedido.ShowDialog();
        }
    }
}
