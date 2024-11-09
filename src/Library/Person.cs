namespace Library;

public class Person
{
    public string Nombre { get; }
    public int Edad { get; }

    public Person(string nombre, int edad)
    {
        this.Nombre = nombre;
        this.Edad = edad;
    }
}