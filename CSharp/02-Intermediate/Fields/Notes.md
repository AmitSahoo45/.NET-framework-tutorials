# Fields

- We should only use constrcutors when we need to initialize our fields based on the values passed from outside 
- In situations like that, we can directly initialise that field. 

```cs
public class Order
    {
        public string OrderId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        List <Order> orders = new List <Order> ();
    }
```

We are directly initializing the order's field without the need to create a constructor.
This approach gives us a freedom, no matter which ever cons is called, the orders field will always be filled.

## Readonly field
- We declare a field with readonly modifier to make sure that the field is only assigned once.
- So in that case it can be initialized by cons or the way we have described above.

#### Why do we need this?
creating safety to improve robustness in our app.

When I declare something as readonly, then if a developer tries to reinitialize a variable, such a thing won't happen.
