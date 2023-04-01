using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int menu, CicloM = 1, Nit, CFactura = 0;
            string Email, NombreU;
            procedimiento Cprocedimiento = new procedimiento();
            copia_impresion CyP = new copia_impresion();

            do
            {
                
                Console.WriteLine("Programa de facturacion Publicmart");
                Console.WriteLine("seleccione una opcion");
                Console.WriteLine("1) Facturacion.");
                Console.WriteLine("2) Reportes de facturacion.");
                Console.WriteLine("3) Cerrar Programa");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        
                        Console.WriteLine("ingrese el nombre del cliente:");
                        NombreU = Console.ReadLine();
                        Console.WriteLine("ingrese el Nit del cliente:");
                        Nit = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el correo del cliente");
                        Email = Console.ReadLine();
                        
                        Cprocedimiento.RegistroProducto();
                        Cprocedimiento.PagoyPuntos();
                        Cprocedimiento.MuestraFactura(NombreU, Nit, Email);
                        CFactura = CFactura + 1;
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("el total de facturas realizadas es: " + CFactura);
                        Console.WriteLine();
                        Console.WriteLine("el total de producots vendidos son:");
                        Console.WriteLine("-pan: " + Cprocedimiento.Cpan1 + " total vendido: " + Cprocedimiento.Cpan1 * 1.1);
                        Console.WriteLine("-azucar: " + Cprocedimiento.Cazucar1 + " total vendido: " + Cprocedimiento.Cazucar1 * 5);
                        Console.WriteLine("-galletas: " + Cprocedimiento.Cgalletas1 + " total vendido: " + Cprocedimiento.Cgalletas1 * 7.3);
                        Console.WriteLine("-granola: " + Cprocedimiento.Cgranola1 + " total vendido: " + Cprocedimiento.Cgranola1 * 32.5);
                        Console.WriteLine("-Jugo de Naranja: " + Cprocedimiento.Cjugo1 + " total vendido: " + Cprocedimiento.Cjugo1 * 17.95);
                        Console.WriteLine();
                        Console.WriteLine("el total de puntos generados son: " + Cprocedimiento.Cpuntos1);
                        Console.WriteLine();
                        Console.WriteLine("el total de ventas con tarjeta son: " + Cprocedimiento.CventasT1);
                        Console.WriteLine("el total de ventas en efectivo son: " + Cprocedimiento.CventasE1);
                        Console.WriteLine("el total de ventas en general es: " + (Cprocedimiento.CventasE1+ Cprocedimiento.CventasT1));
                        Console.ReadKey();
                        break;
                    case 3:
                        CicloM = 0;
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("la opcion elegida no existe");
                        break;
                }
                Console.Clear();
            } while (CicloM == 1);
        }
        
    }
}
