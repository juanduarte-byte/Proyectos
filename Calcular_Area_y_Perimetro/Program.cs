using System;

namespace FigurasGeometricas
{
    // Clase Cuadrado
    public class Cuadrado
    {
        public double Lado { get; set; }

        public Cuadrado(double lado)
        {
            Lado = lado;
        }

        public double CalcularArea()
        {
            return Lado * Lado; // Área = lado * lado
        }

        public double CalcularPerimetro()
        {
            return 4 * Lado; // Perímetro = 4 * lado
        }
    }

    // Clase Rectángulo
    public class Rectangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Rectangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return Base * Altura; // Área = base * altura
        }

        public double CalcularPerimetro()
        {
            return 2 * (Base + Altura); // Perímetro = 2 * (base + altura)
        }
    }

    // Clase Círculo
    public class Circulo
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public double CalcularArea()
        {
            return Math.PI * Radio * Radio; // Área = π * radio^2
        }

        public double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio; // Perímetro = 2 * π * radio
        }
    }

    // Clase Triángulo
    public class Triangulo
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double @base, double altura)
        {
            Base = @base;
            Altura = altura;
        }

        public double CalcularArea()
        {
            return (Base * Altura) / 2; // Área = (base * altura) / 2
        }

        public double CalcularPerimetro(double lado1, double lado2, double lado3)
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
            Console.WriteLine();

            // 3. Círculo
            Console.WriteLine("Cálculo para un Círculo:");
            Console.Write("Introduce el radio del círculo: ");
            double radioCirculo = Convert.ToDouble(Console.ReadLine());
            Circulo circulo = new Circulo(radioCirculo);
            Console.WriteLine($"Área del círculo: {circulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del círculo: {circulo.CalcularPerimetro()}");
            Console.WriteLine();

            // 4. Triángulo
            Console.WriteLine("Cálculo para un Triángulo:");
            Console.Write("Introduce la base del triángulo: ");
            double baseTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce la altura del triángulo: ");
            double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el lado 1 del triángulo: ");
            double lado1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el lado 2 del triángulo: ");
            double lado2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Introduce el lado 3 del triángulo: ");
            double lado3 = Convert.ToDouble(Console.ReadLine());
            Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
            Console.WriteLine($"Área del triángulo: {triangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro del triángulo: {triangulo.CalcularPerimetro(lado1, lado2, lado3)}");
        }
    }
}