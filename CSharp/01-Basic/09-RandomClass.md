# Random Classes
It allows generating pseudo-random numbers in C# code. Numbers are "pseudo-random" as they are generated algorithmically.

### Why Use?
Handy for creating simulations, games, unique IDs, introducing variation in algorithms and more. Anywhere requiring some controlled randomness.

### Features
- Has various methods like Next(), NextBytes(), NextDouble() etc to get random integers, bytes, doubles etc
- Next(10) returns integer between 0 and 9
- NextDouble() returns 0.0 to 1.0
- Can specify upper bounds for ranges
- Can provide random seed to reproduce sequences

### Implementation
```cs
Random rnd = new Random();

int randomNum = rnd.Next(100); // Integer 0-99
double randomDouble = rnd.NextDouble(); // 0.0 to 1.0

bool coinToss = rnd.NextDouble() < 0.5; // Simulate coin toss
```