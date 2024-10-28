using EjercicioAbstraccion;

class Program
{
    static void Main(string[] args)
    {
        int opcion;
        do
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Calcular área del triángulo");
            Console.WriteLine("2. Convertir metros a kilómetros");
            Console.WriteLine("3. Sumar dos números");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la base del triángulo: ");
                    double baseTriangulo = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese la altura del triángulo: ");
                    double altura = double.Parse(Console.ReadLine());
                    AreaTriangulo triangulo = new AreaTriangulo(baseTriangulo, altura);
                    triangulo.Calcular();
                    triangulo.Imprimir();
                    break;

                case 2:
                    Console.Write("Ingrese los metros: ");
                    double metros = double.Parse(Console.ReadLine());
                    ConvertirMetrosAKilometros conversion = new ConvertirMetrosAKilometros(metros);
                    conversion.Calcular();
                    conversion.Imprimir();
                    break;

                case 3:
                    Console.Write("Ingrese el primer número: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.Write("Ingrese el segundo número: ");
                    double num2 = double.Parse(Console.ReadLine());
                    SumaNumeros suma = new SumaNumeros(num1, num2);
                    suma.Calcular();
                    suma.Imprimir();
                    break;

                case 4:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción inválida, por favor intente de nuevo.");
                    break;
            }

            Console.WriteLine();
        } while (opcion != 4);
    }
}
