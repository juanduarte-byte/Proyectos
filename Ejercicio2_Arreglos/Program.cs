using System;

namespace BusquedaDeUnElemetoEnUnArreglo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombres = new string[5];
            string? leerNombre;
            string nombre = "";

            //Le pedimos al usuario que ingrese el primer nombre, y se usa un for para seguir pidiendo y agregando al arreglo los nombres
            Console.WriteLine("Ingrese un nombre: ");
            leerNombre = Console.ReadLine();
            if (leerNombre != null)
                nombre = leerNombre.Trim();
            
            //Este arreglo está fuera del for ya que guarda el primer nombre de la primera instrucción (Es con fines de que sea diferente la instrucción)
            nombres[0] = nombre;
            
            for (int i = 1; i < 5; i++)
            {
                //Aquí se vuelve a pedir y la instrucción ya es diferente para que el usuario entienda de que ingrese otro
                Console.WriteLine("Ingrese otro nombre: ");
                leerNombre = Console.ReadLine();
                if (leerNombre != null)
                    nombre = leerNombre.Trim();
                
                nombres[i] = nombre;
            }

            //Aquí declaramos nuevas variables y le pedimos al usuario de cuál nombre quiere buscar
            string nombreParaBuscar = "";

            Console.WriteLine("¿Desea buscar algún nombre registrado? Si es así ingrese el nombre a buscar, de lo contrario de clic en Enter");
            leerNombre = Console.ReadLine();
            
            //Se hace uso de if para validar que contenga algo y pasarlo a otra variable nombreParaBuscar y no arroje una advertencia tambien
            if (leerNombre != null)
            {
                nombreParaBuscar = leerNombre.Trim();
                
                //Se usa un for para recorrer e ir comparando cada elemento de el arreglo
                for (int i = 0; i < nombres.Length; i++)
                {
                    if (nombres[i] != nombreParaBuscar)
                    {
                        continue;
                    }
                    else //si es falso entonces quiere decir que coincidió con el nombre y está en el arreglo
                    {
                        Console.WriteLine($"Se encontró el nombre {nombres[i]}, se registró en el índice {i}");
                        Console.WriteLine("Para mejor comprensión cuente desde cero");
                    }
                }
            }
        }
    }
}