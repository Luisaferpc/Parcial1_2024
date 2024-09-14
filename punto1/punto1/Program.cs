using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;

public class Program
{
    private static void Main(string[] args)
    {
        double sueldo = 1500000, Pcomision = 0.10, venta1, venta2, venta3, beneficio = 100000;
        

        Console.WriteLine("Ingrese el valor de su primer venta: ");
        venta1=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de su segunda venta: ");
        venta2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor de su tercer venta: ");
        venta3 = Convert.ToDouble(Console.ReadLine());

        double ventatotal = venta1 + venta2 + venta3;
        double Vcomision = ventatotal * Pcomision; //para calcular el valor total de la comision


        if (ventatotal > 1000000) 
        {
            Console.WriteLine("Felicitaciones! Ha cumplido la meta del mes para ganar el beneficio.");
            Console.WriteLine("Total de comisiones del mes: "  +Vcomision);
            


            Console.WriteLine("total a pagar(sueldo+comisiones+bonificacion ")


        }








    }
}