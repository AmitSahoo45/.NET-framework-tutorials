## IEnumerable (VV Imp)

- IEnumerable is the base interface for all non-generic collections that can be enumerated. For example, IEnumerable<T> is the base interface for generic collections such as List<T>, Dictionary<TKey,TValue>, and LinkedList<T>. Before generics were available in C# 2.0, the only collection classes in the .NET Framework class library that did not implement IEnumerable were the ArrayList, Hashtable, SortedList, Stack, and Queue classes.
- It's job is to provide a way to iterate through the collection. 
- When a collection class implements the IEnumerable interface, it becomes countable and we can count each individual item in it.
- There are two versions of IEnumerable: 
	* One is that works for generic collections where you have - IEnumerable<T>
	* The other is for non-generic collections where you have - IEnumerable

### Generic and Non-Generic IEnumerables

#### Generic IEnumerable
- The non-generic IEnumerable is implemented by the following classes in the .NET Framework class library:
* Array
* ArrayList
* BitArray
* Hashtable
* Queue
* SortedList
* Stack

- You need to cast the objects back to their original type when retrieving them to access their properties and methods. This can lead to runtime errors.
###### Explaination
- When using a non-generic collection like ArrayList, you can do

```csharp
ArrayList list = new ArrayList();
list.Add("hello"); 
list.Add(5);
```

So it takes strings, integers, anything.
But then when reading the values, the objects are all of type `object`:

```csharp
object item = list[0];
```

If you try to access `item.Length` or other string methods here, it won't work since the compiler only knows it is an `object`.
To make it work, you have to cast it back to the original type:

```csharp
string s = (string)list[0];
int num = (int)list[1]; 

Console.WriteLine(s.Length); //works now after casting
```

So the need to cast it back and forth can lead to runtime errors if you cast to the wrong type.
The typing gets taken care of automatically with generic collections instead.

#### Non-Generic IEnumerable
- Generic collections like List<T> and Dictionary<TKey, TValue> take in a generic type parameter when defined (the <T>, <TKey> etc.).
- This means the collection will only accept that specific type to be added, like List<int> for integers or List<Person> for Person objects.
- The advantage is that no casting is required when accessing the objects, since the compiler knows and enforces the object type. This is safer and avoids runtime errors.

### IEnumerable<T> vs IEnumerable

- IEnumerable<T>:
	* Contains a single method GetEnumerator() that you must implement, while implementing this interface.
	* GetEnumerator() returns an IEnumerator<T> object.
	* If you are implementing IEnumerable<T> to your class, then you must also have to implement the GetEnumerator() method which then returns an IEnumerator<T> object.
	* The IEnumerator<T> provides the ability to iterate through the collection by exposing a Current property that points at the object we are currently at in the location. 