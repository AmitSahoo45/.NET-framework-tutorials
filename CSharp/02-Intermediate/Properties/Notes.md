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

