# Delegate

- It is a reference type variable that holds a reference to the methods. 
- It is similar to function pointers in C/C++.
- ***The reference can be changed at runtime***. 
- These are the **type-safe pointer** of any method.
- holds 0 to n number of method references.
- Delegates are mainly used in implementing the call-back methods and events.
- Delegates can also be used in “anonymous methods” invocation.
- Anonymous Methods(C# 2.0) and Lambda expressions(C# 3.0) are compiled to delegate types in certain contexts. Sometimes, these features together are known as anonymous functions.

### Syntax
A delegate type is declared using the `delegate` keyword, followed by the return type of the method that the delegate will reference, the name of the delegate type, and the parameters of the method.

```cs
delegate void MyDelegate();
delegate int DelegateDemo(int a, int b);
delegate void DlgDisplay(string a);

static int Add(int a, int b)
{
    return a + b;
}

static int Multiply(int a, int b)
{
    return a * b;
}

DelegateDemo fptr = new DelegateDemo(Add);
fptr += Multiply;

fptr.GetInvocationList()[1].DynamicInvoke(10, 20);
// If you have appended multiple funcs then use this to call a particular one by passing an index what i have passed here is 1. 
```

**Delegate acts like a Queue**

## Anonymous Methods
An anonymous function in C# is a function that is defined without a name. It is also known as a lambda expression. Anonymous functions can be used in places where a delegate is expected. They are useful for writing concise and readable code.

sometimes you are forced to create a method. 
like 1 single line of code. 
You have to write it as an anonymous block coz you don't want to reusablility and explainability. 
this is kinda somewhat similar to inline()
this is only anonymous to dev but complier gives name to it.

```cs
fptr += delegate (int x, int y) { return x + y; };
```

or 

```cs
fptr += (int x, int y) => {return x + y;};
```

```cs
fptr += (x,y) => {return x + y;};
```

```cs
fptr += (x,y) => x + y;
```

```cs
DlgDisplay dlgd = a => Console.WriteLine(a);
```
*Lambda expression with one single arguement.*

What is Func Delegate and Action Delegate?
#### Func Delegate
* `Func` is a generic delegate that represents a method that takes a variable number of arguments and returns a value.
* `Func<T, TResult>` represents a method that takes an input of type `T` and returns a result of type `TResult`.

```cs
Func<int, int, int> func = (x, y) => x + y;
```

#### Action Delegate
* `Action` is a generic delegate that represents a method that takes a variable number of arguments and does not return a value.
* `Action<T>` represents a method that takes an input of type `T` and does not return a value.

```cs
Action<string, string> FullName = (firstName, LastName) => Console.WriteLine(firstName + LastName);
```

### Delegate is same to Function Oriented Programming as Interface is to OOPS
A. 