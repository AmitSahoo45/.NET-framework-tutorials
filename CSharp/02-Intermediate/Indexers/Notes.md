# Indexers

Indexers is a way to access elements in a class that represent a list of values.

```cs
string[] skills = { "C++", "JavaScript", "TypeScript", "SQL" };
Console.WriteLine(skills[0]);
```

Using an indexer is easier.
Using the key it is easier and shorter.

### Declaring an Indexer
We can declare an indexer just like we define a property.

**Note**: If you are working with a class that has the semantic of a collection like List, array or dictionary, you can use the collection's indexer. 
It is an easier way to access your collection.