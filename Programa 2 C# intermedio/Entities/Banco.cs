using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programa_2_C__intermedio.Entities
{
    internal class Banco
    {
        Cliente cliente1 = new Cliente("Pedro");
        Cliente cliente2 = new Cliente("Antonio");
        Cliente cliente3 = new Cliente("Juana");



        public void Depositar()
        {
            cliente1.depositar(1234.56);
            cliente2.depositar(9876.54);
            cliente3.depositar(7685.94);
        }

        public void obtenerDepositosTotales() {
            Console.WriteLine("Los depósitos totales en el banco es: " + (cliente1.Ahorros + cliente2.Ahorros + cliente3.Ahorros));
        }
    }

   

}
