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
    public partial class RelatorioClientes : Form
    {
        public RelatorioClientes()
        {
            InitializeComponent();
            
     
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RelatorioClientes_Load(object sender, EventArgs e)
        {
            DadosArmazenados dadosArmazenados = new DadosArmazenados();

            foreach(var item in DadosArmazenados.clientes)
            {
                list_box_clientes.Items.Add(item.GetNome() + " - " + item.GetCpfCnpj());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
