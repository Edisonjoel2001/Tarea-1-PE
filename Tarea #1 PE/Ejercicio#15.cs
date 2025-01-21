/*Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 13.Crea una clase que represente una persona. La clase debe tener los siguientes atributos: nombre, apellido, edad, género.
 * Los métodos deben permitir establecer y obtener los valores de los atributos.
 * También debe tener un método que imprima la información de la persona.
 */

using System;

class Persona
{
    // Atributos de la clase
    private string nombre;
    private string apellido;
    private int edad;
    private string genero;

    // Constructor para inicializar los atributos
    public Persona(string nombre, string apellido, int edad, string genero)
    {
        this.nombre = nombre;
        this.apellido = apellido;
        this.edad = edad;
        this.genero = genero;
    }

    // Métodos para obtener y establecer el valor de nombre
    public string ObtenerNombre()
    {
        return nombre;
    }

    public void EstablecerNombre(string nuevoNombre)
    {
        nombre = nuevoNombre;
    }

    // Métodos para obtener y establecer el valor de apellido
    public string ObtenerApellido()
    {
        return apellido;
    }

    public void EstablecerApellido(string nuevoApellido)
    {
        apellido = nuevoApellido;
    }

    // Métodos para obtener y establecer el valor de edad
    public int ObtenerEdad()
    {
        return edad;
    }

    public void EstablecerEdad(int nuevaEdad)
    {
        if (nuevaEdad >= 0)
        {
            edad = nuevaEdad;
        }
        else
        {
            Console.WriteLine("La edad no puede ser negativa.");
        }
    }

    // Métodos para obtener y establecer el valor de género
    public string ObtenerGenero()
    {
        return genero;
    }

    public void EstablecerGenero(string nuevoGenero)
    {
        genero = nuevoGenero;
    }

    // Método para imprimir la información de la persona
    public void ImprimirInformacion()
    {
        Console.WriteLine($"Nombre: {nombre} {apellido}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"Género: {genero}");
    }
}

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase Persona
        Persona persona1 = new Persona("Edison", "Cabezas", 23, "Masculino");

        // Imprimir la información de la persona
        persona1.ImprimirInformacion();

        // Modificar los atributos de la persona
        persona1.EstablecerNombre("Edison");
        persona1.EstablecerApellido("Cabezas");
        persona1.EstablecerEdad(23);
        persona1.EstablecerGenero("Masculino");

        // Imprimir la información después de la modificación
        Console.WriteLine("\nInformación modificada de la persona:");
        persona1.ImprimirInformacion();
    }
}


