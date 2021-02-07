using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinha_do_tio_bill
{
    public class Quentinha
    {
        private String nome;
        private String descricao;
        private Decimal preco;

        public String GetNome()
        {
            return this.nome;
        }

        public void SetNome (String nome)
        {
            this.nome = nome;
        }

        public String GetDescricao ()
        {
            return this.descricao;
        }

        public void SetDescricao (String descricao)
        {
            this.descricao = descricao;
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
