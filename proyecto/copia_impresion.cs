using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;
using System.Runtime.InteropServices;

namespace proyecto
{
   
    internal class copia_impresion
    {
       public void copiaF(string _NombreU, int _NIt, string _Email, int Nfactura,double pan, double azucar, double galletas, double granola, double jugo, double total, int puntos)
       {
            procedimiento proc = new procedimiento();
            double totalI = (total * 0.12) + (total * 0.05);

            string RutaArch = "C:/Users/josue/Documents/factura/factura_NO" + Nfactura + ".html";


            using (StreamWriter writer = new StreamWriter(RutaArch,true))
            {
                writer.WriteLine("<html>");
                writer.WriteLine("<head><title> factura </title></head>");
                writer.WriteLine("<body>");
                writer.WriteLine("Supermercado PublicMart");
                writer.WriteLine("<br>");
                writer.WriteLine(DateTime.Now.ToString());
                writer.WriteLine("<br>");
                writer.WriteLine("NO factura: " + Nfactura);
                writer.WriteLine("<br>");
                writer.WriteLine("Nit:" + _NIt);
                writer.WriteLine("<br>");
                writer.WriteLine("Cliente: " + _NombreU);
                writer.WriteLine("<br>");
                writer.WriteLine("producto......................................cantidad..............................precio Unitario");
                writer.WriteLine("<br>");
                writer.WriteLine("Pan Frances..................................." + Convert.ToString(pan / 1.1) + "................Q.1.10");
                writer.WriteLine("<br>");
                writer.WriteLine("Libra de azucar..............................." + Convert.ToString(azucar / 5) + "...............Q.5.00");
                writer.WriteLine("<br>");
                writer.WriteLine("Caja de Galletas............................." + Convert.ToString(galletas / 7.3) + "............Q.7.30");
                writer.WriteLine("<br>");
                writer.WriteLine("Caja de Granola............................." + Convert.ToString(granola / 32.5) + ".............Q.32.50");
                writer.WriteLine("<br>");
                writer.WriteLine("Ltr. jugo naranja............................." + Convert.ToString(jugo / 17.95) + ".............Q.17.95");
                writer.WriteLine("<br>");
                writer.WriteLine("total sin impuestos: " + "{0:n2}", total);
                writer.WriteLine("<br>");
                writer.WriteLine("total impuestos: " + "{0:n2}", totalI);
                writer.WriteLine("<br>");
                writer.WriteLine("total con impuestos: " + "{0:n2}", (totalI + total));
                writer.WriteLine("<br>");
                if (puntos > 0)
                {
                    writer.WriteLine("pago con tarjeta");
                }
                else
                {
                    writer.WriteLine("pago en efectivo");
                }
                writer.WriteLine("<br>");
                writer.WriteLine("los puntos acumulados por su compra son: " + puntos);
                writer.WriteLine("<br>");
                writer.WriteLine("<br>");
                writer.WriteLine("<br>");
                writer.WriteLine("Una copia de la factura se enviará al correo: " + _Email);
                writer.WriteLine("</body>");

            }

       }
    }

}
