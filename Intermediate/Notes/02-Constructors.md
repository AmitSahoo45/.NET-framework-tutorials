# Constructors

A method that is called when an instance of a class is created. 

##### Why?
Put an object in an early state. 

##### Example
```cs
public class MyClass
{
    public MyClass()
    {
        Console.WriteLine("Constructor called");
    }
}
```

1. Default Constructor:
- Called when an object is created
- No parameters
- Even if not defined, then the compiler automatically create a default constructor. It will be in ILE.
- It sets them to their default values like null, 0, false, etc.

2. Parameterized Constructor:
- Called when an object is created
- Accepts parameters
- It must be defined

#### Constructor Overloading
- Multiple constructors with different parameters(method signature - return type, name, and parameters)
- Multiple constructors with the same name

eg. 
```cs
public class MyClass{
    public MyClass(int x) {
        // Code
    }

    public MyClass(string x) {
        // Code
    }
}
```

Why overloading? Code reusability or as per our requirement.

