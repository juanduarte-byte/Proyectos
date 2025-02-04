using System;

namespace FigurasGeometricas
{
    // Clase base FiguraGeometrica
    public abstract class FiguraGeometrica
    {
        public abstract double CalcularArea();
        public abstract double CalcularPerimetro();
    }

    // Clase Cuadrado
    public class Cuadrado : FiguraGeometrica
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public override double CalcularArea()
        {
            return Lado * Lado; // Área = lado * lado
        }

        public override double CalcularPerimetro()
        {
            return 4 * Lado; // Perímetro = 4 * lado
        }
    }

    // Clase Rectángulo
    public class Rectangulo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public override double CalcularArea()
        {
            return Base * Altura; // Área = base * altura
        }

        public override double CalcularPerimetro()
        {
            return 2 * (Base + Altura); // Perímetro = 2 * (base + altura)
        }
    }

    // Clase Círculo
    public class Circulo : FiguraGeometrica
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio; // Área = π * radio^2
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio; // Perímetro = 2 * π * radio
        }
    }

    // Clase Triángulo
    public class Triangulo : FiguraGeometrica
    {
        public override double CalcularArea(double ladoA, double ladoB, double ladoC)
        {
            double semiPerimetro = (ladoA + ladoB + ladoC) / 2;
            double calculoParaArea = semiPerimetro * (semiPerimetro - ladoA) * (semiPerimetro - ladoB) * (semiPerimetro - ladoC);
            return Math.Sqrt(calculoParaArea);
        }

        public override double CalcularPerimetro(double lado1, double lado2, double lado3)
        {
            return lado1 + lado2 + lado3; // Perímetro = lado1 + lado2 + lado3
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // 1. Cuadrado
            Console.WriteLine("Cálculo para un Cuadrado:");
            Console.Write("Introduce el lado del cuadrado: ");
            double ladoCuadrado = Convert.ToDouble(Console.ReadLine());
            Cuadrado cuadrado = new Cuadrado(ladoCuadrado);
            Console.WriteLine($"Área del cuadrado: {cuadrado.CalcularArea()}");
            Console.WriteLine($"Perímetro del cuadrado: {cuadrado.CalcularPerimetro()}");
            Console.WriteLine();

            // 2. Rectángulo
            Console.WriteLine("Cálculo para un Rectángulo:");
            Console.Write("Introduce la base del rectángulo: ");
            double baseRectangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce la altura del rectángulo: ");
            double alturaRectangulo = Convert.ToDouble(Console.ReadLine());
            Rectangulo rectangulo = new Rectangulo(baseRectangulo, alturaRectangulo);
            Console.WriteLine($"Área del rectángulo: {rectangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del rectángulo: {rectangulo.CalcularPerimetro()}");
        }
    } 
}