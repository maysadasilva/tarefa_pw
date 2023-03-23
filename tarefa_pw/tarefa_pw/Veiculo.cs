using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa_pw
{
    public class Veiculo
    {
        public int numerodeAssentos;
        public string modelo;
        
        public string ExibirdadosVeiculo()
        {
            return "Número de assentos: " + numerodeAssentos + ", Modelo do veículo: " + modelo;
        }

    }
}
