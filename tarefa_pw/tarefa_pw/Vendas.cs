using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_pw
{
    public class Vendas
    {
        private int Id;
        private string Produto;
        private int Data;

        public string ListaProdutos()
        {
            return "Id da venda: " + Id + ", Produto: " + Produto + ", Data da Venda: " + Data;
        }

        public Vendas(int id, string produto, int data)
        {
            Id = id;
            Produto = produto;
            Data = data;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public void SetProduto(string produto)
        {
            Produto = produto;
        }

        public void SetData(int data)
        {
            Data = data;
        }

        public int getId()
        {
            return Id;
        }

        public string getProduto()
        {
            return Produto;
        }

        public int getData()
        {
            return Data;
        }


    }
}
