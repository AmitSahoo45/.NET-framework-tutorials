## Classes

A class is the building block of a software application. Classes are used to create objects that can be manipulated and reused.

Our real world app consists of 3 layers:
a. Presentation Layer - Postview: Purely resposible for the presentation to the user
b. Business Logic Layer - Post
c. Data Access/Persistence Layer - PostRepository - Save/Load from DB

### Class Anatomy
- Data (represented by fields)
- Behavior (represented by methods/functions)

UML of a class - Person

Fields:
- Name: String
- Age: byte
- Height: Float
- Weight: Float


Methods:
- Walk()
- Run()
- Eat()
- Sleep()

# Object
- An instance of a Class.

If Person is a class, then John, Mary and Scott are instances of Person.

```cs
public class Person
{
    public string Name;

    public void Introduce(){
        Console.WriteLine("My name is " + Name);
    }
}
```

We use Pascal Case for naming classes and camel Case for params of methods.
In real world apps we should not declare fields using public.

```cs
Person person = new Person();
// or
var person = new Person();
```

* Instance - Accessible from an object

```cs
var person = new Person();
person.Introduce();
```

* Class - Accessible from the class

```cs
Person.Introduce(person);
// or
Console.WriteLine(person.Name);
```

#### Why use static members?
- To represent concepts that are singleton
- DateTime.Now
- Console.WriteLine

###### Declaring static members

```cs
public class Person
{
    public static string Name;
    public static void Introduce(){
        Console.WriteLine("My name is " + Name);
    }
}
```

