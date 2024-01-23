# Method Overriding
- Modifying the implementation of an inherited method
- Overriding methods is very common in object-oriented programming

# Method Overloading
- Defining multiple methods with the same name but different parameters

Overloading and Overriding are two different things.

In C#, we can override a method by using the override keyword. The overridden method must have the same name, return type, and parameters as the method in the base class. The base keyword is used to access the members of the base class from within the derived class.
The class which will be overriden must be declared as virtual.
The virtual declared method, may or may not be overriden in the derived class.
If you don't override the inherited method, then the base class method is called.

```csharp
    public class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw a shape");
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }
```
