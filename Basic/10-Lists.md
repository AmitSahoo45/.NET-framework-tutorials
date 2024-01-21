# Lists

- Lists represent a collection of objects that can be accessed by index.
- Provides similar capabilities as arrays but are dynamic in size.

### Why Lists vs Arrays?
- Arrays have fixed size. Lists resize automatically.
- Useful when number of elements is not known or keeps changing.
- Lists have their own methods like Add, Remove, Contains etc.

##### Declaration
```cs
List<string> names = new List<string>(); 
```

##### Common Operations
```cs
// Add item to list  
names.Add("John"); 

// Insert at particular index
names.Insert(0, "Mike");  

// Remove item
names.Remove("John");

// Other methods
names.Count; // Get total items
names.Sort(); // Sorts alphabetically
```

##### Loops
```cs
// Print all items
foreach(string name in names) {
  Console.WriteLine(name); 
}
```
