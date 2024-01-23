The scope of a block is indicated by curly braces. 

```c#
{
    byte a = 1;
    {
        byte b = 2;
        {
            byte c = 3;
            {
                byte d = 4;
                Console.WriteLine(a + b + c + d); // 10
            }
        }
    }
}
```

here we have 3 blocks of code. The first block contains the variable `a`, the second block contains the variable `b` and `c`, and the third block contains the variable `d`. The variable `a` is accessible in all blocks, but the variable `b` and `c` are only accessible in their own block. The variable `d` is only accessible in its own block.

