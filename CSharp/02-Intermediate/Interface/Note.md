# Interface

- It is a contract which defines some methods and objects that has to be implemented by the classes which implements the interface.
- It uses the keyword `interface` to define an interface.
- It's naming convention is to start with capital `I`.
- It can only have abstract methods and constants.
- It can't have constructors.
- This is also an user-defined data type only.

| Class | Interface |
| ----- | --------- |
| It is a user-defined data type. | It is a user-defined data type. |
| Contains Methods. Abstract classes contains both abstract and non-abstract methods. | Contains only abstract methods. |

Notes: 
- Every abstract method should be implemented in the class which implements the interface.
- Interface enables multiple inheritance in C#.
- A child class is responsible for implementing the methods interface which it has implemented.
- Interfaces tells what a class can do, not how it will do.
- Interfaces can't have private members. They are by default public and abstract.
- Interface cannot have fields because they represent a particular implementation of data, but they can have properties

PS: Abstract methods are the methods without body.

**Syntax**
```csharp
interface  <interface_name >
{
    // declare Events
    // declare indexers
    // declare methods 
    // declare properties
}
```

**Syntax for Implementing Interface**:
```csharp
class class_name : interface_name
```

**Advantage of Interface**:
- It is used to achieve loose coupling.
- It is used to achieve total abstraction.
- To achieve component-based programming
- To achieve multiple inheritance and abstraction.
- Interfaces add a plug and play like architecture into applications.




