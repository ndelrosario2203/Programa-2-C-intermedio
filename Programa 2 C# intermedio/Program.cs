using Programa_2_C__intermedio.Entities;

namespace Programa_2_C__intermedio
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Banco banco = new Banco();
            banco.Depositar();
            banco.obtenerDepositosTotales();
        }
    }
}