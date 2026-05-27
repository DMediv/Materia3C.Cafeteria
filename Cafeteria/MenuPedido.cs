using Materia3C.Cafeteria.Cafetria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Materia3C.Cafeteria.Cafeteria
{
    internal class MenuPedido
    {
        static void Main(string[] args)
        {
            Bebidas[] pedido = new Bebidas[5];
            pedido[0] = new BebidasCalientes("Americano", "Grande", 45f, 95.50f);
            pedido[1] = new BebidasCalientes("Chai Flamingo", "Mediano", 50f, 60.00f);
            pedido[2] = new BebidasFrias("Frappe Taro", "Grande", 75f, 10);
            pedido[3] = new BebidasFrias("Latte Caramelo", "Chico", 65f, 5);
            pedido[4] = new BebidasFrias("Frapuchino", "Chico", 65f, 7);

            Console.WriteLine("===== COMANDA DE BARRA =====\n");
           
            foreach (Bebidas bebida in pedido)
            {
                Console.WriteLine(bebida.Preparar());
                
                if (bebida is BebidasCalientes caliente)
                {
                    if (caliente.temperatura > 88)
                    {
                        Console.WriteLine("[!] ADVERTENCIA: ¡Cuidado, bebida muy caliente!");
                    }
                    
                    Console.WriteLine();
                }

            }
            float total = 0;
            foreach (Bebidas bebida in pedido)
            {
                total = total + bebida.precio;
            }
            Console.WriteLine("===================");
            Console.WriteLine("TOTAL A PAGAR: $" + total);

        }
    }
}
