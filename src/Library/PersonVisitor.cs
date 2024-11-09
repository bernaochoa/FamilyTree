namespace Library;

public class PersonVisitor : IVisitor<Person>
{
    public void Visit(Node<Person> node)
    {
        Console.WriteLine($"Nombre: {node.Value.Nombre}, Edad: {node.Value.Edad}");
    }
}