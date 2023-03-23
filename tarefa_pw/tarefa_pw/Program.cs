using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_pw
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente(1, "Maria", "9999999998");
            Cliente c2 = new Cliente(2, "José", "89899989998");
            Cliente c3 = new Cliente(3, "Julia", "5888788888");
            Cliente c4 = new Cliente(4, "Diogo", "2699898992");

            Console.WriteLine("\n---------------------------");
            List<Cliente> listaCliente = new List<Cliente>();
            listaCliente.Add(c1);
            listaCliente.Add(c2);
            listaCliente.Add(c3);
            listaCliente.Add(c4);

            for(int i=0;i<listaCliente.Count;i++)
            {
                Console.WriteLine(listaCliente[i].DadosdoCliente());
            }

            Console.ReadKey();
        }
    }
}
