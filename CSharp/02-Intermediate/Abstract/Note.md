# Abstract Classes and Members

## Abstract Modifier
- Indicates that a class or member is missing implementation

```csharp
public abstract class Shape
{
	public abstract double Area { get; }
	public abstract double Perimeter { get; }
	public abstract void Draw();
}

public class Circle : Shape
{
	public double Radius { get; set; }

	public override double Area => Math.PI * Radius * Radius;

	public override double Perimeter => 2 * Math.PI * Radius;

	public override void Draw()
	{
		Console.WriteLine("Drawing a circle");
	}
}
```

Some important points about abstract classes and members:
- Do not include implementation for abstract members.
```csharp
public abstract double Area { get; } // no implementation
```

- The class that contains abstract members must be marked as abstract. (vvv imp)
- An abstract class cannot be instantiated.
```csharp
var shape = new Shape(); // not allowed
```
This wont compile. 

- An abstract class can contain abstract members and non-abstract members. 
- A non-abstract class derived from an abstract class ***must provide implementations*** for all inherited abstract members.
```csharp
public class Circle : Shape
{
	public override void Draw()
	{
		Console.WriteLine("Drawing a circle");
	}
}
```

- In the derieved class, the abstract method(s) are overriden using the *override* keyword.

#### Why use abstract?
- When you want to provide some common behavior, while forcing other developers to follow your design.

Lets take the above example. We declare Shape as abstract and make Draw() an abstract method. 
So any dev who will inherit Shape class, has to provide a definition for Draw() method.

> if we don't override the abstract method, we will get an error

-------------------------------------------------------------------------