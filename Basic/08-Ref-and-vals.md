# Reference Types and Value Types

Arrays and String maps to System.Array and System.String

All primitive types are structures.
They are very small types. 
They take no more than 8 bytes.
We can create custom classes like person or calculator.

These classes and structures are treated differently.

Structures are value types meanwhile classes are reference types.

### Value Types
- When we create a variable that is a value type, a part of memory called Stack is allocated for that variable. 
- Memory Allocation is done automatically. 
- When this variable goes out of scope it will immediately be deallocated by the garbage collector(CLR).


### Reference Types
- You need to allocate memory yourself. 
- Use the new operator with classes. 
- Memory allocated on heap. So if you create an object and that object goes out of scope, it will continue to exist on heap for a little while.
- Garbage collector will deallocate it when it has time.

**Imp**: When you copy an object to a new variable depending on whether that object is value type or referenc type, there will be two different outcomes. 

```cs
var anotherobject = someobject;
```

```cs
var a = 10;
var b = a;
b++;
```

What will be the value of a?
10
Because ints are value types. 

When we copy a value type, the new variable will be a copy of the original variable in the target location memory. 

```cs
var array1 = new int[] { 1, 2, 3 };
var array2 = array1;

array2[0] = 0;
```

What will be the first element of array1?
0
Because object is created on heap, 
Its address is stored in stack that will point to that object.
array1 point references to the heap. 

array2 will point to the same address of array1.


**Imp**: When you copy a reference type, the new variable will be a copy of the original variable in the target location memory.


