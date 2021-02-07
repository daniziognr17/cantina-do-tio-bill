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
    public partial class ExcluirQuentinha : Form
    {
        public ExcluirQuentinha()
        {
            InitializeComponent();
        }

        private void combo_quentinhas_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void ExcluirQuentinha_Load(object sender, EventArgs e)
        {
            foreach(var item in DadosArmazenados.quentinhas)
            {
                combo_quentinhas.Items.Add(item.GetNome() + " - " + item.GetDescricao() + " - " + item.GetPreco().ToString());
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DadosArmazenados.quentinhas.RemoveAt(combo_quentinhas.SelectedIndex);
            this.Close();
        }
    }
}
