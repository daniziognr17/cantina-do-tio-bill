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
    public partial class RelatorioFinancas : Form
    {
        public RelatorioFinancas()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void RelatorioFinancas_Load(object sender, EventArgs e)
        {
            Decimal numPedidosRealizados = 0;
            Decimal numPedidosCancelados = 0;
            Decimal totalPedidosRealizados = 0;
            Decimal totalPedidosCancelados = 0;

            foreach(var item in DadosArmazenados.pedidos)
            {
                if (item.GetStatus() == "Cancelado")
                {
                    numPedidosCancelados++;
                    totalPedidosCancelados += item.GetPreco();
                } 
                else
                {
                    numPedidosRealizados++;
                    totalPedidosRealizados += item.GetPreco();
                }
            }

            nPedidosRealizados.Text = numPedidosRealizados.ToString();
            nPedidosCancelados.Text = numPedidosCancelados.ToString();
            totPedidosRealizados.Text = "R$ " + totalPedidosRealizados.ToString();
            totPedidosCancelados.Text = "R$ " + totalPedidosCancelados.ToString();
            Decimal totalLiquido = totalPedidosRealizados - totalPedidosCancelados;
            totLiquido.Text = "R$ " + totalLiquido.ToString();
            
        }
    }
}
