/*Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 8. 1.	Crea un programa que solicita al usuario ingresar una calificación y luego muestre un mensaje según la calificación ingresada 
 * (por ejemplo: "Aprobado" si la calificación es mayor o igual a 60, "Reprobado" si es menor a 60).
 */

using System;

class Program
{
    static void Main()
    {
        // Solicitar al maestro la nota

        Console.WriteLine("Ingresa una nota entre (0 a 100):");

        // Esta es nuestra variable, para almacenar la nota

        int nota;

        // Validar que el usuario ingrese un número entero válido dentro del rango esperado

        if (int.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 100)
        {
            // Aqui comprobamos si la calificación es aprobatoria o reprobatoria

            if (nota >= 60)
            {
                Console.WriteLine("Felicidades, Aprobado");
            }
            else
            {
                Console.WriteLine("Reprobado");
            }
        }
        else
        {
            // Mensaje de error si la entrada no es válida

            Console.WriteLine("Entrada no válida. Por favor, ingresa un número entero entre 0 y 100.");
        }
    }
}
