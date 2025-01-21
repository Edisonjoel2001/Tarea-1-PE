/* Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 3.	Imprimir los números del 1 al 50:
a.	Para números divisibles por 3, imprima "Fizz".
b.	Para números divisibles por 5, imprima "Buzz".
c.	Para números divisibles por 3 y 5, imprime "FizzBuzz".
d.	En cualquier otro caso, imprima el número.
 */


using System; //Aqui es donde empieza y contiene las funciones basicas de C# 

class Ejercicio3   // Esta es nuestra clase principal llamada Ejercicio#3
{
    static void Main() //Aqui se empieza a ejecutar el programa 
    {
        for (int i = 1; i <= 50; i++)  //Bucle for, que itera desde i = 1 hasta i = 50
        {
            if (i % 3 == 0 && i % 5 == 0) 
            {
                Console.WriteLine("FizzBuzz"); //Verifica si i es divisible por 3 y 5. Si lo es, imprime "FizzBuzz".
            }
            else if (i % 3 == 0)
            {
                Console.WriteLine("Fizz"); //Si el número no cumple la primera condición, verifica si es divisible solo por 3. Si lo es, imprime "Fizz"
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine("Buzz"); //Si no cumple las dos condiciones anteriores, verifica si es divisible por 5. Si lo es, imprime "Buzz".
            }
            else  //Si no se cumple ninguna de las condiciones anteriores, imprime el número.

            {
                Console.WriteLine(i);  //Imprime el valor de i en la consola si cumple la condición del for.
            }
        }
    }
}
