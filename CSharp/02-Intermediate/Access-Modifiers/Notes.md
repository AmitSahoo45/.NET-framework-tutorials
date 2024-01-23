# Access Modifiers

A way to control access to a class and/or its members.
The more a class reveals it's information, the more it is risky it is.

#### Why?
- create safety in our apps.
- create robustness

## Public
- Accessible from anywhere
- No restrictions

```csharp
public class Person
{
	public string Name { get; set; }
}

public class Program
{
	public static void Main()
	{
		var person = new Person();
		person.Name = "John";
		Console.WriteLine(person.Name);
	}
}
```

## Private
- Accessible only from within the class
- Most restrictive

```csharp
public class Person
{
	private string Name { get; set; }
}

public class Program
{
	public static void Main()
	{
		var person = new Person();
		person.Name = "John"; // Error
		Console.WriteLine(person.Name); // Error
	}
}
```

## Protected

- Accessible from within the class and any of it's derived class
- Used in inheritance

```csharp
public class Person
{
	protected string Name { get; set; }

	protected int CalculateRating()
	{
		// some logic
	}
}

public class Employee : Person
{
	public void DoWork()
	{
		Name = "John";
	}
}

public class Program
{
	public static void Main()
	{
		var employee = new Employee();
		employee.Name = "John"; // Error
		employee.CalculateRating(); // Error
	}
}
```

The problem here is whatever classes that will be derived from this class will still be able to see CalculateRating() method. 
This is not what we want. We want to hide this method from the outside world.
Therefore it is better to avoid using protected.

## Internal 

Internal is a modifier that is often used with classes and not their members.
- Accessible only from within the same assembly (project)

```csharp
internal class Person
{
	public string Name { get; set; }
}

// in same assembly
var person = new Person();

// in another assembly
var person = new Person(); // Error
```

Inside that domain it is accessible from anywhere.
Assembly is a .dll or .exe file or class library.

## Protected Internal

- Accessible from within the same assembly or any of it's derived class

```csharp
public class Person
{
	protected internal string Name { get; set; }
	protected internal int CalculateRating()
	{
		// some logic
	}
}