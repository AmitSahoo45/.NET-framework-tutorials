There are two types of type conversion in C#:

- Implicit conversion
- Explicit conversion

### Explicit Conversion

- also called as type casting. 
- we have conversion between non compatible types. 


```c#
int x = 10;
byte y = (byte)x;
```

Here there is data loss. 
The compiler wont compile and it will not allow implicit type conversion. 
So we have to explicitly convert the type. 
So the above method is preferrable. 

```c#
int x = 10;
byte y = x;
```

This is not compatible. 

Sometimes we are working with types that are not compatible but still want to convert them. 
Like say we want to convert a string to an integer. 
In that situations like that string and int are not compatible and you cannot convert it to an integer. 

So we need a different mechanism. 

```c#
string s = "10";
int x = Convert.ToInt32(s);
int j = int.Parse(s);
```

ToByte - Converts a given value to a byte.
ToInt16 - Converts a given value to a short.
ToInt32 - Converts a given value to an integer.
ToInt64 - Converts a given value to a long.

-----------------------------------------------------

### Implicit Conversion

- 

```c#
byte b = 1;  // 00000001
int i = b; // 00000000 00000000000 000000 00000001
```

A byte as you know only takes one byte of data. But an int can take 4 bytes of data.
So we can easily copy byte to an int. 
The above binary rep says everything. 
There is no data loss. 