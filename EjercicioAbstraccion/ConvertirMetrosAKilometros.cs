

namespace EjercicioAbstraccion 
{
    public class ConvertirMetrosAKilometros : FormulaMatematica
    {
        private double metros;

        public ConvertirMetrosAKilometros(double metros)
        {
            this.metros = metros;
        }

        public override void Calcular()
        {
            double kilometros = metros / 1000;
            Console.WriteLine($"{metros} metros son {kilometros} kilómetros");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Metros: {metros}");
        }
    }
}
