/* Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 5. Calcula la suma de los primeros 100 números enteros utilizando un bucle " while ".
 */

using System;   //Importa el espacio de los nombres, que contiene funciones basicas de C#


class Ejercicio5 //Creamos una clase ejercicio, esta es nuestra clase principal llamada ejercicio5
{
    static void Main()   //Este es el punto de entrada de programa 
    {
        int i = 1; // Inicializa la variable de control con 1

        int suma = 0; //Aqui inicializamos la variable que almacenará la suma con 0

        while (i <= 100) // Aqui ejecuta el bucle mientras i sea menor o igual a 100
        {
            suma += i; // En esta parte sumamos el valor actual de i a la variable suma

            i++; // Incrementa i en 1
        }

        Console.WriteLine("Este es el resultado de la suma: " + suma); //Imprmimos en pantalla este mensaje con el resultado
    }
}


