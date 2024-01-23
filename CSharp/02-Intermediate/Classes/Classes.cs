namespace ClassesEg
{
    public class Person
    {
        public string Name;
        // parameterized constructor
        public Person(string name)
        {
            this.Name = name;
        }

        public static void main(string[] args)
        {
            var person = new Person("John");
        }
    }
}

