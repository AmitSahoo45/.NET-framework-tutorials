## Namespace 

As we are building apps using .NET framework, we will be dealing with completely oops programming concepts. 
Therefore we will have to write 1000's of classes while building enterprise level of applications. 
To manage these classes we have something called as namespaces. 

Namespace is a container for classes. 
In C# a namespace can contain tons of classes that are related to each other. 
We have name spaces for working with db, images, security, etc. 

But in real world applications, these namespaces will also grow significantly. 
Therefore we also need a way to organise these namespaces. 
That's where we use an Assembly. 

An assembly is a **container for related namespaces**. 
Physically its a file on the disk which can either be an executable(.exe) or a DLL which stands for dynamically linked library.
> So when you compile an application the compiler builds one or more assemblies depending on how you partition your code in the next picture.

| Assembly | Assembly | <br/>
| Assembly | Assembly |

##### Some differences between Assembly, Namespace and Class 
| Assembly | Namespace | Class |
| ---- | ---- | ---- |