using System;

// Classe abstraite Animal
public abstract class Animal
{
    public string Nom { get; protected set; }
    public int NombrePattes { get; protected set; }

    public Animal(string nom, int nombrePattes)
    {
        Nom = nom;
        NombrePattes = nombrePattes;
    }

    public abstract void Move();
    
    public void Eat()
    {
        Console.WriteLine($"{Nom} mange.");
    }
}

// Espèce Humain
public class Humain : Animal
{
    public Humain(string nom) : base(nom, 2) { }

    public override void Move()
    {
        Console.WriteLine($"{Nom} marche sur ses deux jambes.");
    }
}

// Espèce Singe
public class Singe : Animal
{
    public Singe(string nom) : base(nom, 2) { }

    public override void Move()
    {
        Console.WriteLine($"{Nom} saute de branche en branche.");
    }
}

// Espèce Éléphant
public class Elephant : Animal
{
    public Elephant(string nom) : base(nom, 4) { }

    public override void Move()
    {
        Console.WriteLine($"{Nom} marche lentement avec ses quatre pattes.");
    }
}

// Espèce Tortue
public class Tortue : Animal
{
    public Tortue(string nom) : base(nom, 4) { }

    public override void Move()
    {
        Console.WriteLine($"{Nom} avance lentement en traînant sa carapace.");
    }
}

// Espèce Lézard
public class Lezard : Animal
{
    public Lezard(string nom) : base(nom, 4) { }

    public override void Move()
    {
        Console.WriteLine($"{Nom} se déplace en rampant sur le sol.");
    }
}

// Classe principale
class Program
{
    static void Main(string[] args)
    {
        Humain humain = new Humain("Humain");
        Singe singe = new Singe("Singe");
        Elephant elephant = new Elephant("Éléphant");
        Tortue tortue = new Tortue("Tortue");
        Lezard lezard = new Lezard("Lézard");

        // Test des méthodes
        Console.WriteLine("## Méthode Move ##");
        humain.Move();
        singe.Move();
        elephant.Move();
        tortue.Move();
        lezard.Move();

        Console.WriteLine("\n## Méthode Eat ##");
        humain.Eat();
        singe.Eat();
        elephant.Eat();
        tortue.Eat();
        lezard.Eat();
    }
}
