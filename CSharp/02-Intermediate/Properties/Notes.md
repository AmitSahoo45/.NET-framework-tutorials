# Properties

A property is a class member that encapsulates a getter and setter method for accessing a field.
To create a getter and setter property using less code.

```cs
        public void setDOB(DateTime dob)
        {
            if (dob != DateTime.MinValue) 
                this.dob = dob;
        }

        public DateTime getDob() {  return dob; }
```

This is how we set the getter and setter methods. 
But doing this for 100's of props is kinda hectic.

```cs
private string _name;

        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
```

Rather than doing the above, we can do it in this way.
The data types should remain the same.

Or we can also use auto implemented properties.
```cs
public bool sex { get; set; }
```

when c# compiler sees this it internally creates a private field for this.

### Properties of Interfaces
- Code readability: Interface constitutes a declaration about your intentions, so it defines the capability of your class. 
- Code semantics: Interface defines the semantics of your class, so it defines the meaning of your class. It defines what your class should look like and what your objects should do. Making the code a lot clearer. 
- Code maintainability - Help reduce coupling and easily exchange implemtations without the underlying code being affected.
- Design Pattern: Using contracts, abstracts and interfaces you can design and implement a lot of design patterns.
- Multiple inheritance: C# does not support multiple inheritance, but it does support multiple interface inheritance. Interface can be our gateaway to multiple inheritance. 