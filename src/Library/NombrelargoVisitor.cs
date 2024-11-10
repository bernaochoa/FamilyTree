namespace Library;

public class NombrelargoVisitor : IVisitor<Person>
{
    private string nombrelargo = string.Empty;

    public string Nombrelargo
    {
        get
        {
            return this.nombrelargo;
        }
    }

    public void Visit(Node<Person> node)
    {
        // Comprobamos si el nombre del nodo actual es el más largo encontrado hasta ahora
        if (node.Value.Nombre.Length > nombrelargo.Length)
        {
            nombrelargo = node.Value.Nombre;
        }
    }
}