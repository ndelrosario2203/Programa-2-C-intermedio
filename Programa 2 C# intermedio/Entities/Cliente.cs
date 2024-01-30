using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Programa_2_C__intermedio.Entities
{
    internal class Cliente
    {
        public Cliente(string nombre) { 
            Nombre = nombre;
            Ahorros = 0;
        }
        public string? Nombre { get; set; }
        public double Ahorros { get; set; }

        public void depositar(double d) {
            Ahorros += d;
        }
        public void sacar(double d) { 
            Ahorros -= d;
        
        }
        public double obtenerAhorros() {
            return Ahorros;
        }

        public void imprimirAhorros() {
            Console.WriteLine("El usuario " + Nombre + " tiene $" + Ahorros + " ahorrados actualmente.");
        }
    }
}
