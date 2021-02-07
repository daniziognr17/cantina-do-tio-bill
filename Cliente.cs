using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantinha_do_tio_bill
{
    public class Cliente
    {
        private String nome;
        private String telefone;
        private String cpfcnpj;
        private String endereco;

        public String GetNome ()
        {
            return this.nome;
        }

        public void SetNome (String nome)
        {
            this.nome = nome;
        }

        public String GetTelefone ()
        {
            return this.telefone;
        }

        public void SetTelefone (String telefone)
        {
            this.telefone = telefone;
        }

        public String GetCpfCnpj ()
        {
            return this.cpfcnpj;
        }

        public void SetCpfCnpj (String cpfcnpj)
        {
            this.cpfcnpj = cpfcnpj;
        }

        public String GetEndereco ()
        {
            return this.endereco;
        }

        public void SetEndereco (String endereco)
        {
            this.endereco = endereco;
        }


    }
}
