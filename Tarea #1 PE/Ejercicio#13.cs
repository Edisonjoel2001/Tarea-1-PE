/*Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 13.Crea una clase que represente un punto en el plano cartesiano. La clase debe tener los siguientes atributos: x, y.
 * Los métodos deben permitir establecer y obtener los valores de los atributos.
 */

using System;

class Punto
{
    // Atributos de la clase
    private double x;
    private double y;

    // Constructor para inicializar los atributos
    public Punto(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    // Métodos para obtener y establecer el valor de x
    public double ObtenerX()
    {
        return x;
    }

    public void EstablecerX(double nuevoX)
    {
        x = nuevoX;
    }

    // Métodos para obtener y establecer el valor de y
    public double ObtenerY()
    {
        return y;
    }

    public void EstablecerY(double nuevoY)
    {
        y = nuevoY;
    }

    // Método para mostrar las coordenadas del punto
    public void MostrarCoordenadas()
    {
        Console.WriteLine($"Punto: ({x}, {y})");
    }
}

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase Punto
        Punto punto1 = new Punto(5.6, 3.5);

        // Mostrar las coordenadas iniciales del punto
        punto1.MostrarCoordenadas();

        // Modificar las coordenadas del punto usando los métodos
        punto1.EstablecerX(7.0);
        punto1.EstablecerY(5.5);

        // Mostrar las coordenadas después de la modificación
        Console.WriteLine("\nPunto después de modificación:");
        punto1.MostrarCoordenadas();
    }
}

