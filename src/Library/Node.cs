using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library;

public class Node<T>
{
    private T value;
    private List<Node<T>> children = new List<Node<T>>();

    public T Value
    {
        get
        {
            return this.value;
        }
    }

    public ReadOnlyCollection<Node<T>> Children
    {
        get
        {
            return this.children.AsReadOnly();
        }
    }

    public Node(T value)
    {
        this.value = value;
    }

    public void AddChildren(Node<T> children)
    {
        this.children.Add(children);
    }

    public void Accept(IVisitor<T> visitor)
    {
        visitor.Visit(this);
        foreach (var children in this.children)
        {
            children.Accept(visitor);
        }
    }
}
