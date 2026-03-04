// See https://aka.ms/new-console-template for more information
using System;

namespace CalculaISR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de ISR segun DGII - 2026");
            Console.Write("Ingrese el sueldo del empleado (RD$): ");

            double sueldo = Convert.ToDouble(Console.ReadLine());
            string resultadoISR = CalcularISR(sueldo);

            Console.WriteLine("----Resultado:");
            Console.WriteLine($"Sueldo: RD$ {sueldo:0.00}");
            Console.WriteLine($"ISR a pagar: {resultadoISR}");
        }

        static string CalcularISR(double sueldo)
        {
            
            double limiteExento = 416220;
            double limiteMedio = 624329;

            if (sueldo <= limiteExento)
            {
                return "N/A";
            }
            else if (sueldo <= limiteMedio)
            {
                double exceso = sueldo - limiteExento;
                double isr = exceso * 0.15; 
                return $"RD$ {isr:0.00}";
            }
            else // sueldo > 624,329
            {
                double exceso = sueldo - limiteMedio;
                double cuotaFija = (limiteMedio - limiteExento) * 0.15;
                double isr = cuotaFija + (exceso * 0.20); 
                return $"RD$ {isr:0.00}";
            }
        }
    }
}
