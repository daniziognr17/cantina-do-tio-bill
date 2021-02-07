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
    public partial class RelatorioQuentinhas : Form
    {
        public RelatorioQuentinhas()
        {
            InitializeComponent();
        }

        private void RelatorioQuentinhas_Load(object sender, EventArgs e)
        {
            foreach(var item in DadosArmazenados.quentinhas)
            {
                listview_quentinhas.Items.Add(item.GetNome() + " - " + item.GetDescricao() + " - R$ " + item.GetPreco());
            }

            nQuentinhasCadastradas.Text = "Número de quentinhas cadastradas: " + DadosArmazenados.quentinhas.Count();
        }
    }
}
