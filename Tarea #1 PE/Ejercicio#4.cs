/* Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 4.Imprime los números del 1 al 10 utilizando un bucle " while ".
 */

using System;  //Aqui estan las funciones basicas de C#

class Ejercicio4 //Creamos nuestra clase principal  llamada Ejercicio4
{
    static void Main() ////Aqui es donde empieza la ejecucion del programa 
    {
        int i = 1; // Aqui empezamos la clase de control

        while (i <= 10) // Aqui se ejecuta el bucle mientras i sea menor o igual a 10
        {
            Console.WriteLine(i); // Aqui imprimimos, el valor de i

            i++; // Incrementa i en 1
        }
    }
}
