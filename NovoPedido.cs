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
    public partial class NovoPedido : Form
    {
        public NovoPedido()
        {
            InitializeComponent();
        }

        private void NovoPedido_Load(object sender, EventArgs e)
        {
            foreach(var item in DadosArmazenados.quentinhas)
            {
                listview_quentinhas.Items.Add(item.GetNome() + " - " + item.GetDescricao() + " - R$ " + item.GetPreco());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido();
            pedido.SetCliente(DadosArmazenados.usuarioLogado);
            pedido.SetPreco(calcTotal());
            pedido.SetStatus("pedido realizado");

            List<int> indexesSelecionados = new List<int>();
            List<Quentinha> quentinhas = new List<Quentinha>();

            for (int i = 0; i < listview_quentinhas.SelectedItems.Count; i++)
            {
                int index = listview_quentinhas.SelectedItems[i].Index;
                indexesSelecionados.Add(index);
            }

            for (int i = 0; i < DadosArmazenados.quentinhas.Count; i++)
            {
                for (int j = 0; j < indexesSelecionados.Count; j++)
                {
                    if (i == indexesSelecionados[j])
                    {
                        quentinhas.Add(DadosArmazenados.quentinhas[i]);
                        break;
                    }
                }
            }

            pedido.SetQuentinhas(quentinhas);
            DadosArmazenados.pedidos.Add(pedido);
            this.Close();
        }

        private void listview_quentinhas_SelectedIndexChanged(object sender, EventArgs e)
        {
            total_a_pagar.Text = "Total: R$ " + calcTotal();
        }

        public Decimal calcTotal ()
        {
            Decimal preco = 0;
            List<int> indexesSelecionados = new List<int>();
            for (int i = 0; i < listview_quentinhas.SelectedItems.Count; i++)
            {
                int index = listview_quentinhas.SelectedItems[i].Index;
                indexesSelecionados.Add(index);
            }

            for (int i = 0; i < DadosArmazenados.quentinhas.Count; i++)
            {
                for (int j = 0; j < indexesSelecionados.Count; j++)
                {
                    if (i == indexesSelecionados[j])
                    {
                        preco += DadosArmazenados.quentinhas[i].GetPreco();
                        break;
                    }
                }
            }

            if (indexesSelecionados.Count >= 5)
            {
                double discount = (2.15 / 100) * double.Parse(preco.ToString());
                preco -= Decimal.Parse(discount.ToString());
            }
            return preco;
        }
    }
}
