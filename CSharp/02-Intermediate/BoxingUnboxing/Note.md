# Types in C#

### 1. Value Types
- Are stored in Stack
- Are derived from System.ValueType
- Are implicitly derived from System.Object
- Examples: int, float, double, char, bool, byte, struct, enum
- Are copied by value
- Are destroyed immediately after the scope is lost

### 2. Reference Types
- Are stored in Heap
- Are derived from System.Object
- Are copied by reference
- Are destroyed by the Garbage Collector
- Examples: class, interface, delegate, string, object
- Are destroyed when there are no more references to them

The object is the base class of all classes in .NET Framework

### 3. Boxing and Unboxing
- Boxing is the process of converting a value type to the type object or to any interface type implemented by this value type.
```csharp
int i = 123;
object o = i;  // implicit boxing
```

or

```csharp
object o = 123;  // explicit boxing
```

- Unboxing is the process of converting the type object to a value type.

```csharp
int i = (int)o;  // unboxing
```