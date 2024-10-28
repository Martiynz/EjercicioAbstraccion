

namespace EjercicioAbstraccion
{
    public class AreaTriangulo : FormulaMatematica
    {
        private double baseTriangulo;
        private double altura;

        public AreaTriangulo(double baseTriangulo, double altura)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
        }

        public override void Calcular()
        {
            double area = (baseTriangulo * altura) / 2;
            Console.WriteLine($"El área del triángulo es: {area}");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Base: {baseTriangulo}, Altura: {altura}");
        }
    }
}
