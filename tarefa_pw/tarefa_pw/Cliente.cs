using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_pw
{
    public class Cliente
    {
        private int Id;
        private string Nome;
        private string Telefone;
       
        public string DadosdoCliente()
        {
            return "Id" + "Nome" + "Telefone";
        }
        public Cliente(int id, string nome, string telefone) 
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
        }

        public void SelId(int id)
        {
            Id = id;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }

        public void SetTelefone(string telefone)
        {
            Telefone = telefone;
        }

        public int getId()
        {
            return Id;
        }

        public string getNome()
        {
            return Nome;
        }

        public string getTelefone()
        {
            return Telefone;
        }

    }
}
