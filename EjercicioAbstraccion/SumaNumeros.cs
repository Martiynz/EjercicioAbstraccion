

namespace EjercicioAbstraccion
{
    public class SumaNumeros : FormulaMatematica
    {
        private double num1;
        private double num2;

        public SumaNumeros(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public override void Calcular()
        {
            double suma = num1 + num2;
            Console.WriteLine($"La suma de {num1} y {num2} es: {suma}");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Número 1: {num1}, Número 2: {num2}");
        }
    }
}
