using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinha_do_tio_bill
{
    public class Pedido
    {
        private Cliente cliente;
        private List<Quentinha> quentinhas = new List<Quentinha>();
        private String status;
        private Decimal preco;

        public Cliente GetCliente ()
        {
            return this.cliente;
        }

        public void SetCliente (Cliente cliente)
        {
            this.cliente = cliente;
        }

        public List<Quentinha> GetQuentinhas ()
        {
            return this.quentinhas;
        }

        public void SetQuentinhas (List<Quentinha> quentinhas)
        {
            this.quentinhas = quentinhas;
        }

        public String GetStatus ()
        {
            return this.status;
        }

        public void SetStatus (String status)
        {
            this.status = status;
        }

        public Decimal GetPreco ()
        {
            return this.preco;
        }

        public void SetPreco (Decimal preco)
        {
            this.preco = preco;
        } 
    }
}
