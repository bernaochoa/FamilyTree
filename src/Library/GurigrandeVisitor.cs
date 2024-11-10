namespace Library;

public class GurigrandeVisitor : IVisitor<Person>
{
    private int gurigrande = 0;

    public int Gurigrande
    {
        get
        {
            return this.gurigrande;
        }
    }

    public void Visit(Node<Person> node)
    {
        // Comparamos la edad de la persona actual con la edad mayor registrada
        if (node.Value.Edad > gurigrande)
        {
            gurigrande = node.Value.Edad;
        }
    }
}
