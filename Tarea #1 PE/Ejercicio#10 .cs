/*Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 10.Escribe un programa que solicite al usuario ingresar un número del 1 al 7 
 * luego muestre el día de la semana correspondiente (por ejemplo: 1 para "Lunes", 2 para "Martes", etc.) 
 */

using System; //Importa el espacio de los nombres, que contiene funciones basicas de C#

class Ejercicio10 //Creamos una clase ejercicio, esta es nuestra clase principal llamada ejercicio9
{
    static void Main() //Este es el punto de entrada de programa 
    {
        // Solicitar que ingrese un número entre 1 y 7

        Console.WriteLine("Por favor, ingresa un número del 1 al 7 para obtener el día de la semana:");

        // Variable para almacenar el número ingresado

        int numero;

        // Validar que el usuario ingrese un número entero entre 1 y 7

        if (int.TryParse(Console.ReadLine(), out numero) && numero >= 1 && numero <= 7)
        {
            // Evaluar el número ingresado y mostrar el día de la semana correspondiente

            switch (numero)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:

                    // Este bloque nunca se alcanzará gracias a la validación anterior

                    break;
            }
        }
        else
        {
            // Mensaje de error si la entrada no es válida

            Console.WriteLine("Entrada no válida. Por favor, ingresa un número entre 1 y 7.");
        }
    }
}
