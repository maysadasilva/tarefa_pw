using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_pw
{
    public class Vendas
    {
        private int IDVenda;
        private string DatadaVenda;

        public Vendas(int idvenda, string datadavenda)
        {
            IDVenda = idvenda;
            DatadaVenda = datadavenda;
        }

        public int getIDVenda()
        {
            return IDVenda;
        }

        public string getDatadaVenda()
        {
            return DatadaVenda;
        }

    }
}
