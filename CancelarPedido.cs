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
    public partial class CancelarPedido : Form
    {
        public CancelarPedido()
        {
            InitializeComponent();
        }

        private void CancelarPedido_Load(object sender, EventArgs e)
        {
            List<Pedido> pedidos = new List<Pedido>();

            for (int i = 0; i < DadosArmazenados.pedidos.Count; i++)
            {
                if (DadosArmazenados.usuarioLogado.GetCpfCnpj() == DadosArmazenados.pedidos[i].GetCliente().GetCpfCnpj())
                {
                    pedidos.Add(DadosArmazenados.pedidos[i]);
                }
            }

            foreach (var item in pedidos)
            {
                combo_pedidos.Items.Add(item.GetQuentinhas().Count + " Quentinhas - R$ " + item.GetPreco() + " - " + item.GetStatus());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DadosArmazenados.pedidos[combo_pedidos.SelectedIndex].SetStatus("Cancelado");
            this.Close();
        }
    }
}
