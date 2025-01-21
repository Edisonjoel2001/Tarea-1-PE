/* Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 2.Imprimir los números pares que hay dentro de los 100 primeros números enteros. 
 */

using System; //Aqui estan las funciones basicas de C#

class ejercicio2 //Creamos nuestra clase principal  
{
    static void Main() //Aqui es donde empieza la ejecucion del programa 
    {
        for (int i = 1; i <= 100; i++) //Es el bucle for el cual nos va a separar los numeros pares
        {
            if (i % 2 == 0) //aqui se comprueba si el numero i, es numero par
            {
                Console.WriteLine(i); //Imprime el valor de i, en pantalla si cumple el valor de if 
            }
        }
    }
}
