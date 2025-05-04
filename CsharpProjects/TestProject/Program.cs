// Random dice = new Random();
// int roll = dice.Next(1, 7);
// Console.WriteLine(roll);

// int firstValue = 500;
// int secondValue = 600;
// int largerValue;
// largerValue = Math.Max(firstValue, secondValue);
// Console.WriteLine(largerValue);

var p1 = new Person("Peter", "Gitp", new DateOnly(1980, 1,1));
var p2 = new Person("Egbe", "Etta", new DateOnly(1989, 3,1));

p1.Pets.Add(new Dog("Fred"));
p1.Pets.Add(new Dog("Barnay"));

p2.Pets.Add(new Cat("Beyonce"));
p2.Pets.Add(new Cat("Beyonce1"));

List<Person> people = [p1, p2];

foreach(var person in people) {
    Console.WriteLine($"{person}");

    foreach(var pet in person.Pets){
        Console.WriteLine($"  {pet}");
    }
}
Console.WriteLine(people.Count);
public class Person(string firstName, string lastName, DateOnly birthDay)
{
    public  string First { get; } = firstName;
    public  string Last { get; } = lastName;
    public  DateOnly Birthday { get; } = birthDay;

    public List<Pet> Pets { get; } = new();
    public override string ToString()
    {
        return $"{First} {Last}";
    }
}

public abstract class Pet(string firstName) {
    public string First { get; } = firstName;
    public abstract string MakeNoise();

     public override string ToString()
    {
        return $"{First} and I am a {GetType().Name} and I {MakeNoise()}";
    }
}
public class Cat(string firstName) : Pet(firstName) 
{
    public override string MakeNoise() => "Meow";
}

public class Dog(string firstName) : Pet(firstName) {
    public override string MakeNoise() => "Bark";
}