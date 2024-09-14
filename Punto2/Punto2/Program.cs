public class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Ingrese el valor para coeficiente(a): ");
        double a=Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el valor para coeficiente(b): ");
        double b=Convert.ToDouble(Console.ReadLine());
       
        double X = (-b / a);

        Console.WriteLine("La solucion de la ecuacion es: " + ((a * X) + b));
    }
}