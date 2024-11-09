namespace Library;

public class SumVisitorEdad : IVisitor<Person>
{
    private int totaledades = 0;

    public int TotalEdades
    {
        get
        {
            return this.totaledades;
        }
    }

    public void Visit(Node<Person> node)
    {
        totaledades += node.Value.Edad;
    }
}
