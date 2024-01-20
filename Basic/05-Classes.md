# Classes

- Classes are a way of grouping data and functions together. They are a way of describing something. They are a way of organizing data and functions together.
- They are bulding blocks. 
- These classes combine related variables and functions together. 

The class is a blueprint from which we create objects. 
An object is an instance of a class.

```cs
class Person
{
    public string Name;
    public int Age;
}
```

```cs
Person person1 = new Person();
person1.Name = "John";
person1.Age = 30;

Person person2 = new Person();
person2.Name = "Mary";
person2.Age = 25;

Console.WriteLine($"{person1.Name} is {person1.Age} years old.");
Console.WriteLine($"{person2.Name} is {person2.Age} years old.");
```

> Use the public keyword when creating classes to make your class publically accessible to everyone inside our application. 

CLR takes care of allocating memory to the objects created. 
It has a process called garbage collector which automatically removes unused objects.

you can also use the var keyword.

### Static Modifier

```cs
public class Calculator{
    public int Add(int a, int b){
        return a+b;
    }
}
```

Here is the calculator class with a method named Add.

```cs
public class Calculator{
    public static int Add(int a, int b){
        return a+b;
    }
}
```

When we will add a static keyword to the method, it will become a static method.
We can now access it using the class name.

```cs
Console.WriteLine(Calculator.Add(2, 3));
```

We don't have to create an object to access the static method or we need to. 