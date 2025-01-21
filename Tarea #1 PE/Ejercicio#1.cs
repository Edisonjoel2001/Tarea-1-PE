/* Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 1.Imprimir los números pares que hay dentro de los 100 primeros números enteros. No utilizar la estructura de control "if" para resolver este ejercicio.
 */

using System;  //Importa el espacio de los nombres, que contiene funciones basicas de C#

class Ejercicio //Creamos una clase ejercicio, esta es nuestra clase principal 
{
    static void Main()  //Este es el punto de entrada de programa 
    {
        for (int i = 2; i <= 100; i += 2) // Vamos a utilizar for, para poder ejecutar el programa 
        {
            Console.WriteLine(i); //Aqui es donde imprimimos, el valor de i en la consola 
        }
    }
}
