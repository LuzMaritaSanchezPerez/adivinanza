using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdivinaFruta;

namespace Juego_Adivinar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JuegoFruta juego = new JuegoFruta();

            Console.WriteLine("¡Adivina la fruta!");
            Console.WriteLine("Pista: " + juego.ObtenerPista());

           
            for (int intento = 1; intento <= 2; intento++)
            {
                Console.Write("Intento: ¿Cuál es la fruta? ");
                string respuesta = Console.ReadLine();

                if (juego.Adivinar(respuesta))
                {
                    Console.WriteLine("¡Adivinaste!");
                    break;
                    
                }
                else
                {
                    if (intento == 1)
                        Console.WriteLine(" No adivinaste. Te queda 1 intento.");
                    else
                        Console.WriteLine(" No adivinaste. La fruta era: {juego.ObtenerFruta()}");
                    

                }
                
            }
            Console.WriteLine("Gracias por jugar. ¡Hasta la próxima!");
            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();

        }
    }
}
