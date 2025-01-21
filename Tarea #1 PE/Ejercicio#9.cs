/*Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 9.Desarrolla un programa que pida al usuario ingrese un número y luego determine en qué rango se encuentra
 * (por ejemplo: "Menor que 10", "Entre 10 y 20", "Mayor que 20") 
 */

using System;  //Importa el espacio de los nombres, que contiene funciones basicas de C#



class Ejercicio9  //Creamos una clase ejercicio, esta es nuestra clase principal llamada ejercicio9
{
    static void Main() //Este es el punto de entrada de programa 
    {
        // Pedimos que el usuariio ingrese un numero

        Console.WriteLine("Hola, ingresa un número:");

        // Nuestra variable double es numero

        double numero;

        // Aqui empezamos, la validacion de los numeros

        if (double.TryParse(Console.ReadLine(), out numero))
        {
            // Evaluar el rango del número

            if (numero < 10)
            {
                Console.WriteLine("El número es menor que 10.");
            }
            else if (numero >= 10 && numero <= 20)
            {
                Console.WriteLine("El número está entre 10 y 20.");
            }
            else
            {
                Console.WriteLine("El número es mayor que 20.");
            }
        }
        else
        {
            // Aqui emitimos un mensaje, si el numero es incorrecto

            Console.WriteLine("La entrada no es válida. Por favor, ingresa un número.");
        }
    }
}
