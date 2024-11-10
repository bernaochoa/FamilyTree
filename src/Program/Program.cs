using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear instancias de Persona
            Person p1 = new Person("Carlos", 70);
            Person p2 = new Person("Ana", 68);
            Person p3 = new Person("Luis", 40);
            Person p4 = new Person("María", 38);
            Person p5 = new Person("Jorge", 18);
            Person p6 = new Person("Lucía", 15);
            Person p7 = new Person("Fernando", 10);

            // Crear nodos para cada Persona
            Node<Person> n1 = new Node<Person>(p1);
            Node<Person> n2 = new Node<Person>(p2);
            Node<Person> n3 = new Node<Person>(p3);
            Node<Person> n4 = new Node<Person>(p4);
            Node<Person> n5 = new Node<Person>(p5);
            Node<Person> n6 = new Node<Person>(p6);
            Node<Person> n7 = new Node<Person>(p7);
            // Establecer relaciones en el árbol genealógico
            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // Visita el árbol aquí
            PersonVisitor personVisitor = new PersonVisitor();
            n1.Accept(personVisitor);
            // Usa el visitador para calcular la suma de las edades
            SumVisitorEdad sumaedades = new SumVisitorEdad();
            n1.Accept(sumaedades);

            Console.WriteLine("La suma de las edades de la familia es: " + sumaedades.TotalEdades);
            //Visitador para encontrar
            GurigrandeVisitor oldestChildVisitor = new GurigrandeVisitor();
            n1.Accept(oldestChildVisitor);
            Console.WriteLine("La edad del hijo más grande es: " + oldestChildVisitor.Gurigrande);

            // Visitador para encontrar el nombre más largo
            NombrelargoVisitor longestNameVisitor = new NombrelargoVisitor();
            n1.Accept(longestNameVisitor);
            Console.WriteLine("El nombre más largo es: " + longestNameVisitor.Nombrelargo);
        }
    }
}
