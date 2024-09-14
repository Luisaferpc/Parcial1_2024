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


        if (ventatotal >= 1000000) // cuanto recibe si cumple con la meta
        {
            Console.WriteLine("Felicitaciones! Ha cumplido la meta del mes para ganar el beneficio.");
            Console.WriteLine("Total de comisiones del mes: "  +Vcomision);
            Console.WriteLine("Total a pagar: " + (sueldo + Vcomision + beneficio));
            Console.WriteLine("Comisiones promedio por cada venta:" +Vcomision/3);
            
            if (venta1 >venta2 && venta1 > venta3)
            {
                Console.WriteLine("La venta mas alta que le genero la mayor comision fue: "+venta1);
            }else if (venta2 >venta1 && venta2 > venta3)
                { Console.WriteLine("La venta mas alta que le genero la mayor comision fue: " + venta2); 
            }else if(venta3 >venta1 && venta3 > venta2)
            {
                Console.WriteLine("La venta mas alta que le genero la mayor comision fue: " + venta3);
            }



        }else // SI NO ALCANZA LA META
        {
            Console.WriteLine("LO SIENTO! No cumplido la meta del mes para ganar el beneficio :( ");
            Console.WriteLine("Total de comisiones del mes: " + Vcomision);
            Console.WriteLine("Total a pagar: " + (sueldo + Vcomision));
            Console.WriteLine("Comisiones promedio por cada venta:" + Vcomision / 3);

            if (venta1 > venta2 && venta1 > venta3)
            {
                Console.WriteLine("La venta mas alta que le genero la mayor comision fue: " + venta1);
            }
            else if (venta2 > venta1 && venta2 > venta3)
            {
                Console.WriteLine("La venta mas alta que le genero la mayor comision fue: " + venta2);
            }
            else if (venta3 > venta1 && venta3 > venta2)
            {
                Console.WriteLine("La venta mas alta que le genero la mayor comision fue: " + venta3);
            }

        }








    }
}