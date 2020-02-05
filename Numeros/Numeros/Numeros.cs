using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System.Linq;
using System.Text;
using System;

namespace Numeros
{
    class Numeros
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Primer Hilo: Números Primos, en el rango de -100 a 0.");
            Thread primerHilo = new Thread(Primos);
            primerHilo.Start();
            primerHilo.Join();
            Console.WriteLine("--------- Presione una Tecla Para Continuar ---------");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Segundo Hilo: Números Multiples de Siete, en el rango de -100 a 0.");
            Thread segundoHilo = new Thread(MultiplosSiete);
            segundoHilo.Start();
            segundoHilo.Join();
            Console.WriteLine("--------- Presione una Tecla Para Continuar ---------");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Tercer Hilo: Números Multiples de Nueve, en el rango de -100 a 0.");
            Thread tercerHilo = new Thread(MultiplosNueve);
            tercerHilo.Start();
            tercerHilo.Join();
            Console.WriteLine("------------------ Fin de Los Hilos -----------------");
            Console.ReadKey();
        }

        static void Primos()
        {
            int contador = 0;
            for (int i = -100; i <= -2; i++)
            {
                for (int j = -100; j <= -1; j++)
                {
                    if (i % j == 0)
                    {
                        contador = contador + 1;
                    }
                }
                if (contador == 2)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(0.1));
                    Console.WriteLine(i);
                }
                contador = 0;
            }
        }

        static void MultiplosSiete()
        {
            for (int i = -100; i < 0; i++)
            {
                if (i % 7 == 0)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(0.1));
                    Console.WriteLine(i);
                }
            }
        }

        static void MultiplosNueve()
        {
            for (int i = -100; i < 0; i++)
            {
                if (i % 9 == 0)
                {
                    Thread.Sleep(TimeSpan.FromSeconds(0.1));
                    Console.WriteLine(i);
                }
            }
        }
    }
}