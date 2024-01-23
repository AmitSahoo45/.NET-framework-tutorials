# Methods

## Signature of a Method
- Name
- Number and Type of Params make up the signature.

```cs
public int Add(int x, int y) { return x + y; }
```

Here the signature of the method is int, int and int

## Method Overloading

- Method with same name but different signatures. 

```cs
public void Collaborate(int x, int y) { }
public void Collaborate(double x, int y, string s) { }
public void Collaborate(string x, string y) { }
```

- A method with varying number of parameters

## Using Params

```cs
public int Add(int n1, int n2) { return n1 + n2; }
public int Add(int n1, int n2, int n3) { return n1 + n2 + n3; }
public int Add(int n1, int n2, int n3, int n4) { return n1 + n2 + n3 + n4; }
```

- This is not an efficient way to overloading. There is a better way to achieve this.
- We can pass it as an array instead of overloading it. 

```cs
public int Add(int[] arr) { return 1; }

var calc = new Calculator();
var res = calc.Add(new int[] { 1, 2, 3 });
```

This is an efficient way to do it. 
However every time we have to send an array of params, we will have to initialize an array or use the new operator and the *int* array notation.

- There's a simpler way to do this.
- We can include the params keyword at the beginning of the parameter. 

```cs
public int Total(params int[] arr) { return arr.Length; }

var calc = new Calculator();
var res = calc.Add(new int[] { 1, 2, 3 });
var newRes = calc.Total(1, 2, 3, 4);
```

Another implementation of using params:
```cs
class CalculatorNew
{
    public int Add(params int[] nums)
    {
        var sum = 0
        foreach (int i in nums)
            sum += i
        return sum;
    
    static void Main(String[] args)
    {
        CalculatorNew calc = new CalculatorNew();
        calc.Add(new int[] { 1, 2, 3 });
        // or 
        calc.Add(1, 2, 3, 4, 6, 7);
    }
}
```

We can pass n no of arguements or using new and int array notation.

## The 'ref' Modifier
- Any change made to a value that is passed by reference will reflect this change since you are modifying the value at the address and not just the value.

```cs
public void refMethod(ref int a)
{
    a += 2;
}

int a = 1;
refMod.refMethod(ref a);
```

## The 'out' method
- allows you to pass a variable by reference as a paramter to a method. 

```cs
public class OutModifier
{
    public int returnOut(out int a)
    {
        a = 10;
        return a;
    }
}
```
- the parameter is declared with the out parameter.
- you also need to specify out while calling that method.
- It is a design flaw.



