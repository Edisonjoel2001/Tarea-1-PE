/*Instituto Tecnologico "Itecsur"
 * Deber #1
 * Edison Cabezas 
 * Tercer Semestre
 * 12. 1.	Crea una clase llamada "Persona" con atributos como nombre, edad y DNI.
 * Luego, implemente métodos para la clase, como obtener y establecer valores para los atributos.
 */

using System; //Importa el espacio de los nombres, que contiene funciones basicas de C#

class Persona //Creamos una clase ejercicio, esta es nuestra clase principal llamada Persona, lo cual es nuestro ejercicio 12
{
    // Atributos de la clase
    private string nombre;
    private int edad;
    private string dni;

    // Constructor para inicializar los atributos
    public Persona(string nombre, int edad, string dni)
    {
        this.nombre = nombre;
        this.edad = edad;
        this.dni = dni;
    }

    // Métodos para obtener y establecer el nombre
    public string ObtenerNombre()
    {
        return nombre;
    }

    public void EstablecerNombre(string nuevoNombre)
    {
        nombre = nuevoNombre;
    }

    // Métodos para obtener y establecer la edad
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

    // Métodos para obtener y establecer el DNI
    public string ObtenerDNI()
    {
        return dni;
    }

    public void EstablecerDNI(string nuevoDNI)
    {
        dni = nuevoDNI;
    }

    // Método para mostrar la información de la persona
    public void MostrarInformacion()
    {
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
        Console.WriteLine($"DNI: {dni}");
    }
}

class Program
{
    static void Main()
    {
        // Crear una instancia de la clase Persona
        Persona persona1 = new Persona("Edison Cabezas", 23, "1755988357");

        // Mostrar la información inicial
        persona1.MostrarInformacion();

        
        persona1.EstablecerNombre("Edison Cabezas");
        persona1.EstablecerEdad(23);
        persona1.EstablecerDNI("1755988357");

        // Mostrar la información después de la modificación
        Console.WriteLine("\nInformación modificada:");
        persona1.MostrarInformacion();
    }
}

