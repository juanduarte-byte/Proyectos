using System;

namespace Cajero
{
    public class Operaciones
    {
        public double TotalDeCompras { get; set;}
        public double PagoEfectivo { get; set;}

        //Constructor
        public Operaciones (double totalDeCompras, double pagoEfectivo)
        {
            TotalDeCompras = totalDeCompras;
            PagoEfectivo = pagoEfectivo;
        }

        //Método que realiza la resta del pago con el total de compras
        public double RealizarCambio(double cambio = 0.00)
        {
            return cambio = PagoEfectivo - TotalDeCompras;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //Le pedimos al usuario que ingrese el total de compras y su pago en efectivo
            Console.WriteLine("Ingresa el total de compras");
            double totalDeCompras = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingresa el pago en efectivo");
            double pagoEfectivo = Convert.ToDouble(Console.ReadLine());

            //Creamos una nueva instancia de la clase Operaciones y llamamos al método que realiza la diferencia
            Operaciones operaciones = new Operaciones(totalDeCompras, pagoEfectivo);

            double cambio = operaciones.RealizarCambio();

            //Mostramos los datos del la compra realizada
            Console.WriteLine($"\nTOTAL $    {totalDeCompras}");
            Console.WriteLine($"EFECTIVO   {pagoEfectivo}");
            Console.WriteLine($"SU CAMBIO  {cambio}");
        }
    }
}
