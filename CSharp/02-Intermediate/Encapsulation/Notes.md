# Encapsulation

- define fields as private
- provide getter and setter methods as public.

- fields are implementation details which are invisible from outside as it stores how a class stores some details.
- we dont' want anyother classes to get data of it.

```cs
class PersonEncap
    {
        private string _name;

        public void setName(string name)
        {
            if(!String.IsNullOrEmpty(name))
                this._name = name;
        }

        public string getName() { return _name; }
    }
```

By setting setters and getters we can set some logic that are accessing the field.
