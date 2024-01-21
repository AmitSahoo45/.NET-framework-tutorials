# Generic. 

Data type introduced code redundancy is addressed through generic.

**Introduction:**

- Generics are a powerful tool in C# that provides a way to create classes, methods, and interfaces that can operate on different types of data without requiring you to write multiple versions of the same code.
- By using generics, you can create more concise code, easier to read, and easier to maintain.

or 

Generics allow you to write classes, interfaces, methods etc. where the data type is not specified. Instead, the data type gets specified when we actually use or instantiate the generic logic.

**Benefits of Generics:**

- **Type Safety:** Generics help ensure type safety by enforcing that only data of the specified type can be passed to a generic method or class.

- **Code Reusability:** They enable you to write generic code that can be reused for different data types. By creating a generic class or method, you can eliminate the need to write multiple versions of the same code for different data types.

- **Increased Flexibility:** Generics make your code more flexible by allowing it to work with different data types without any modification.

**How Do Generics Work?**

- A generic class, method, or interface is defined using type parameters, **which are placeholders for data types**. Type parameters are declared within angle brackets (< and >) after the name of the generic type.
- When you create an instance of a generic class or call a generic method, you specify the actual data type to use.
- The compiler then generates code specific to the type you provided.

**Syntax:**

To define a generic class, use the following syntax:

```cs
public class GenericClass<T>
{
    private T data;

    public GenericClass(T data)
    {
        this.data = data;
    }

    public T GetData()
    {
        return data;
    }
}
```

**Explanation:**

- `T` is the type parameter. It can be any type, including built-in types like `int`, `double`, or `string`, as well as user-defined types.
- The constructor method takes a parameter of type `T` and assigns it to the `data` field.
- The `GetData()` method returns the value of the `data` field.

**Usage:**

To use the `GenericClass`, you can instantiate it with the desired data type:

```cs
GenericClass<int> intClass = new GenericClass<int>(10);

GenericClass<string> stringClass = new GenericClass<string>("Hello World");
```

Now, you can call the `GetData()` method on each instance to retrieve the data:

```cs
int intValue = intClass.GetData(); // Result: 10

string stringValue = stringClass.GetData(); // Result: "Hello World"
```

By using generics, you can write code that can work with different data types without having to write separate versions of the code for each data type. This makes your code more concise, easier to read, and easier to maintain.

**Constraints on Type Parameters**:

You can also specify constraints on the type parameters used with a generic type. Constraints allow you to limit the types that can be used with a generic type. For example, the following class declares a generic type parameter called `T` that must be a class that implements the `IComparable` interface:

```cs
public class MyGenericClass<T> where T : IComparable {
    private T value;

    public MyGenericClass(T value) {
        this.value = value;
    }

    public T GetValue() {
        return value;
    }
}
```

or 

```cs
        T returnMini<T>(T a, T b) where T : IComparable<T>
        {
            // return a < b ? a : b;
            // This is a wrong way as it cannot be applied to operands where type is T
            return (a.compareTo(b) < 0 ? a : b);
        }

        returnMini<int>(1,2)
```
- It is a generic interface which takes a type parameter T
- It contains a CompareTo() method that compares the current instance with another object of type T
- Should return -1, 0 or 1 if current instance is less than, equal or greater than other object


```cs
        static TReturn GenSynTaxEg<T1, T2, TReturn>(T1 a, T2 b)
            where T1 : IComparable<T1>
            where T2 : IComparable<T2> // or class if you are passing a class
            // where TReturn : new()
            where TReturn: class, new()
            // general can be applied to class or method lvl - delegate and interface is class lvl and it can be applied. 
            // so does index and prop. 
        {
            TReturn obj = new TReturn();
            return default(TReturn);
        }
```

##### Breakdown

This is an example of a C# method that uses multiple generic type parameters along with multiple generic constraints:

Let's break it down:

Method Declaration:

GenSynTaxEg - Name of the generic method
<T1, T2, TReturn> - Declares 3 generic type parameters that will be used
T1 a, T2 b - Method arguments of generic types T1 and T2
Generic Constraints:

where T1 : IComparable<T1>
Constrains T1 to types that implement IComparable
where T2 : IComparable<T2>
Constrains T2 also to be IComparable
where TReturn : new()
Constrains TReturn to types that provide a parameterless constructor
Method Body:

TReturn obj = new TReturn(); - Creates new instance of TReturn using constructor
Returns default(TReturn) - Default value for type
So in summary, this shows:

Multiple generic types in method
Different constraints applied to each generic type parameter
Creating instance of generic type parameter that satisfies constraint
This helps limit generic parameters to types with minimum required capabilities as per business needs.

##### What is IComparable?
The IComparable interface in .NET enables developers to define custom comparison logic for a class. Here are some key points:
It is a generic interface - IComparable<T> where T is the type being compared.
The interface contains one method - CompareTo(T other)
This method compares the current instance (this) with the other object passed.
It should return:
Negative integer if this instance is less than other
Zero if they are equal
Positive integer if this instance is greater

