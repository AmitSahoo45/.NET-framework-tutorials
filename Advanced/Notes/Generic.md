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

- A generic class, method, or interface is defined using type parameters, **which are placeholders for data types**.
- When you create an instance of a generic class or call a generic method, you specify the actual data type to use.
- The compiler then generates code specific to the type you provided.

**Syntax:**

To define a generic class, use the following syntax:

```
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

```
GenericClass<int> intClass = new GenericClass<int>(10);

GenericClass<string> stringClass = new GenericClass<string>("Hello World");
```

Now, you can call the `GetData()` method on each instance to retrieve the data:

```
int intValue = intClass.GetData(); // Result: 10

string stringValue = stringClass.GetData(); // Result: "Hello World"
```

By using generics, you can write code that can work with different data types without having to write separate versions of the code for each data type. This makes your code more concise, easier to read, and easier to maintain.

**Conclusion:**
In this session, we explored the concept of generics in C# and discussed how they can help write type-safe, reusable, and flexible code. With generics, you can simplify your code and improve its maintainability. Feel free to experiment with generics in your code to get a better understanding of their power.