/*Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 11. 1.	Ingresar 2 números y luego un carácter indicando la operación a realizar (+, -, *, /) 
 * reportar el resultado de la operación utilizando la sentencia switch.
 */

using System;  //Importa el espacio de los nombres, que contiene funciones basicas de C#


class Ejercicio11  //Creamos una clase ejercicio, esta es nuestra clase principal llamada ejercicio11
{

    static void Main()  //Este es el punto de entrada de programa 
    {
        // Solicitar al usuario que ingrese dos números

        Console.WriteLine("Hola, ingresa el primer número:");

        double num1 = Convert.ToDouble(Console.ReadLine());  // Leer el primer número

        Console.WriteLine("Ingresa el segundo número:");
        double num2 = Convert.ToDouble(Console.ReadLine());  // Leer el segundo número

        // Solicitar al usuario que ingrese un operador

        Console.WriteLine("ingresa un operador (+, -, *, /):");
        char operador = Convert.ToChar(Console.ReadLine());  // Leer el operador

        // Variable para almacenar el resultado de la operación
        double resultado = 0;

        // Evaluar la operación a realizar usando la sentencia switch
        switch (operador)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                // Validar si el segundo número es distinto de cero antes de realizar la división
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                }
                else
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                    return;  // Termina la ejecución del programa si hay división por cero
                }
                break;
            default:
                // Si el operador no es válido, mostrar mensaje de error
                Console.WriteLine("Operador no válido. Por favor, ingresa un operador válido (+, -, *, /).");
                return;  // Termina la ejecución del programa si el operador no es válido
        }

        // Mostrar el resultado de la operación
        Console.WriteLine("El resultado de la operación es: " + resultado);
    }
}


