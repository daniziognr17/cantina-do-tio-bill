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
    public partial class NovaQuentinha : Form
    {
        public NovaQuentinha()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Quentinha quentinha = new Quentinha();
            quentinha.SetNome(nome_quentinha.Text);
            quentinha.SetDescricao(descricao_quentinha.Text);
            quentinha.SetPreco(preco_quentinha.Value);

            DadosArmazenados.quentinhas.Add(quentinha);
            this.Close();
        }
    }
}
