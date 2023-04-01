using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto
{
    internal class procedimiento
    {
        copia_impresion CyP = new copia_impresion();

        private double pan;
        private double azucar;
        private double galletas;
        private double granola;
        private double jugo;
        private double total;
        private int puntos;
        private int n;
        private int Cpan;
        private int Cazucar;
        private int Cgalletas;
        private int Cgranola;
        private int Cjugo;
        private int Cpuntos;
        private double CventasE;
        private double CventasT;
        private int Nfactura;


        public double Pan { get => pan; set => pan = value; }
        public double Azucar { get => azucar; set => azucar = value; }
        public double Galletas { get => galletas; set => galletas = value; }
        public double Granola { get => granola; set => granola = value; }
        public double Jugo { get => jugo; set => jugo = value; }
        public double Total { get => total; set => total = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public int N { get => n; set => n = value; }
        public int Cpan1 { get => Cpan; set => Cpan = value; }
        public int Cazucar1 { get => Cazucar; set => Cazucar = value; }
        public int Cgalletas1 { get => Cgalletas; set => Cgalletas = value; }
        public int Cgranola1 { get => Cgranola; set => Cgranola = value; }
        public int Cjugo1 { get => Cjugo; set => Cjugo = value; }
        public int Cpuntos1 { get => Cpuntos; set => Cpuntos = value; }
        public double CventasE1 { get => CventasE; set => CventasE = value; }
        public double CventasT1 { get => CventasT; set => CventasT = value; }
        public int Nfactura1 { get => Nfactura; set => Nfactura = value; }

        Program Cprgram = new Program();

        public void RegistroProducto()
        {
            Console.Clear();
            double _pan = 0, _azucar = 0, _galletas = 0, _granola = 0, _jugo = 0, _total = 0;
            int CodigoProducto = 0, cantidad, _n = 0, _Cpan = 0, _Cazucar = 0, _Cgalletas = 0, _Cgranola = 0, _Cjugo = 0;
            char ciclo2 = 's';

            do
            {

                Console.WriteLine("ingrese el codigo del producto");
                CodigoProducto = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese la cantidad de articulos");
                cantidad = int.Parse(Console.ReadLine());

                if (cantidad > 0)
                {


                    switch (CodigoProducto)
                    {
                        case 001:
                            _pan = _pan + (1.10 * cantidad);
                            _n = _n + cantidad;
                            _Cpan = _Cpan + cantidad;
                            Console.WriteLine("Producto registrado");
                            Console.Clear();
                            break;
                        case 002:
                            _azucar = _azucar + (5 * cantidad);
                            _n = _n + cantidad;
                            _Cazucar = _Cazucar + cantidad;
                            Console.WriteLine("Producto registrado");
                            Console.Clear();
                            break;
                        case 003:
                            _galletas = _galletas + (7.30 * cantidad);
                            _n = _n + cantidad;
                            _Cgalletas = _Cgalletas + cantidad;
                            Console.WriteLine("Producto registrado");
                            Console.Clear();
                            break;
                        case 004:
                            _granola = _granola + (32.5 * cantidad);
                            _n = _n + cantidad;
                            _Cgranola = _Cgranola + cantidad;
                            Console.WriteLine("Producto registrado");
                            Console.Clear();
                            break;
                        case 005:
                            _jugo = _jugo + (17.95 * cantidad);
                            _n = _n + cantidad;
                            _Cjugo = _Cjugo + cantidad;
                            Console.WriteLine("Producto registrado");
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("El producto ingresado no esta registrado");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("El numero de articulos debe ser mayor a 0.");
                }

                Console.WriteLine("Desea agregar otro articulo? si=s, no =n ");
                ciclo2 = char.Parse(Console.ReadLine());
            } while (ciclo2 == 's');
            _total = _pan + _azucar + _galletas + _granola + _jugo;
            pan = _pan;
            azucar = _azucar;
            galletas = _galletas;
            granola = _granola;
            jugo = _jugo;
            total = _total;
            n= _n;
            Cpan = Cpan + _Cpan;
            Cazucar = Cazucar + _Cazucar;
            Cgalletas = Cgalletas + _Cgalletas;
            Cgranola = Cgranola + _Cgranola;
            Cjugo = Cjugo + _Cjugo;
        }

        public void PagoyPuntos()
        {
            int _puntos = 0;
            Console.WriteLine("pago efectivo(e) o tarjeta(t)?");
            char pago = char.Parse(Console.ReadLine());

            if (pago == 't' && total < 50)
            {
                _puntos = Convert.ToInt32(total) / 10;
            }
            else
            {
                if (pago == 't' && total > 50 && total < 150)
                {
                    _puntos = Convert.ToInt32(total) / 5;
                }
                else
                {
                    if (pago == 't' && total > 150)
                    {
                        _puntos = Convert.ToInt32(total) / 5;
                    }
                }
            }
            Cpuntos = Cpuntos + _puntos;
            if (pago == 't')
            {
                CventasT1 = CventasT1 + total;
            }
            else
            {
                CventasE1 = CventasE1 + total;

            }

            puntos = _puntos;
            Console.Clear();
        }


        public int NoFactura()
        {
            int Nofactura = 0000, min = 1, max = 1000;
            int _puntos = Convert.ToInt32(Math.Pow(puntos,2));
            Random rnd = new Random();
            int x = rnd.Next(min, max);

            Nofactura = (((2 * x) + _puntos) + (2021 * n)) % 10000;

            return Nofactura;
        }

        public void MuestraFactura(string _NombreU, int _NIt, string _Email)
        {
            Console.WriteLine("Supermercado PublicMart");
            Console.WriteLine(DateTime.Now.ToString());
            int Nfac = NoFactura();
            Console.WriteLine("NO factura: " + Nfac);
            Console.WriteLine("Nit:" + _NIt); Console.WriteLine("Cliente: " + _NombreU);
            Console.WriteLine();

            int filas = 6, columnas = 3;

            string[,] tabla = new string[filas, columnas];

            tabla[0, 0] = "producto                                      ";
            tabla[0, 1] = "cantidad           ";
            tabla[0, 2] = "precio Unitario";
            tabla[1, 0] = "Pan Frances...................................";
            tabla[1, 1] = Convert.ToString(pan / 1.1);
            tabla[1, 2] = ("...............Q.1.10");
            tabla[2, 0] = "Libra de azucar...............................";
            tabla[2, 1] = Convert.ToString(azucar / 5);
            tabla[2, 2] = ("...............Q.5.00");
            tabla[3, 0] = "Caja de Galletas..............................";
            tabla[3, 1] = Convert.ToString(galletas / 7.3);
            tabla[3, 2] = ("...............Q.7.30");
            tabla[4, 0] = "Caja de Granola...............................";
            tabla[4, 1] = Convert.ToString(granola / 32.5);
            tabla[4, 2] = ("...............Q.32.5");
            tabla[5, 0] = "Ltr. jugo naranja.............................";
            tabla[5, 1] = Convert.ToString(jugo / 17.95);
            tabla[5, 2] = ("...............Q.17.95");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write(tabla[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("total sin impuestos: " + "{0:n2}", total);
            double totalI = (total*0.12) + (total*0.05);
            Console.WriteLine("total impuestos: " + "{0:n2}", totalI);
            Console.WriteLine("total con impuestos: " + "{0:n2}", (totalI + total));
            if(puntos > 0)
            {
                Console.WriteLine("pago con tarjeta");
            }
            else
            {
                Console.WriteLine("pago en efectivo");
            }
            Console.WriteLine("los puntos acumulados por su compra son: " + puntos);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Una copia de la factura se enviará al correo: " + _Email);

            CyP.copiaF(_NombreU, _NIt, _Email, Nfac, pan, azucar, galletas, granola, jugo, total, puntos);
        }
    }
}

