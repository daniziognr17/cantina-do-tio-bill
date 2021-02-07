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
    public partial class ClientePedidos : Form
    {
        public ClientePedidos()
        {
            InitializeComponent();
        }

        private void ClientePedidos_Load(object sender, EventArgs e)
        {
            List<Pedido> pedidos = new List<Pedido>();

            for (int i = 0; i < DadosArmazenados.pedidos.Count; i++)
            {
                if (DadosArmazenados.usuarioLogado.GetCpfCnpj() == DadosArmazenados.pedidos[i].GetCliente().GetCpfCnpj())
                {
                    pedidos.Add(DadosArmazenados.pedidos[i]);
                }
            }

            foreach(var item in pedidos)
            {
                lista_pedidos_cliente.Items.Add(item.GetQuentinhas().Count + " Quentinhas - R$ " + item.GetPreco() + " - " + item.GetStatus());
            }
        }
    }
}
