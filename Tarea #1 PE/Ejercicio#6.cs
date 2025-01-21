/* Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 6.Imprimir los números pares que hay dentro de los 100 primeros números enteros utilizando un bucle " while ".
 */

using System;  //Importa el espacio de los nombres, que contiene funciones basicas de C#

class Ejercicio6  //Creamos una clase ejercicio, esta es nuestra clase principal llamada ejercicio6
{
    static void Main()  //Este es el punto de entrada de programa 
    {
        int i = 2; // Comienza con el primer número par

        while (i <= 100) // Ejecuta el bucle mientras i sea menor o igual a 100
        {
            Console.WriteLine(i); // Imprime el número par actual

            i += 2; // Incrementa i en 2 para obtener el siguiente número par
        }
    }
}
