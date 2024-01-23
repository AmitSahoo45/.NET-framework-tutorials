# Enums

Use enums when there are a number of related constants. 

```cs
public enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
```

Enums are used to represent a group of constants.

Rather than declaring multiple constants it is better to declare them in one place. 

What if we want a particular value of enum, then we can use . followed by the enum name.

```cs
Day today = Day.Monday;
```

Enum is internally an enum.
But if you want enum to be a byte making it easier for you to map in your dbs, then you can use the byte keyword during your declaration. 

```cs
public enum Day: byte
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 3,
    Thursday = 4,
    Friday = 5,
    Saturday = 6,
    Sunday = 7
}
```