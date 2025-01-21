/* Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 7.Escribe un programa que evalúe si un número ingresado por el usuario es positivo, negativo o cero.
 */

using System; //Importa el espacio de los nombres, que contiene funciones basicas de C#


class Ejercicio7 //Creamos una clase ejercicio, esta es nuestra clase principal llamada ejercicio7
{
    static void Main()  //Este es el punto de entrada de programa 
    {
        // Aqui imprimimos en pantalla el siguiente mensaje 
        Console.WriteLine("Por favor, ingresa un número:");

        // Utilizamos la variable double, para almacenar los datos ingresados
        double numero;

        // Aqui utilizamos para validar los datos ingresados
        if (double.TryParse(Console.ReadLine(), out numero))
        {
            // Aqui vemos si el numero es positivo o negativo
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");  //  Aqui imprimimos en pantalla el siguiente mensaje
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");  // Aqui imprimimos en pantalla el siguiente mensaje
            }
            else
            {
                Console.WriteLine("El número es cero.");  // Aqui imprimimos en pantalla el siguiente mensaje 
            }
        }
        else
        {
            // Este es el mensaje que va a reflejar, el mensaje de error
            Console.WriteLine("La entrada no es válida. Por favor, ingresa un número.");
        }
    }
}
