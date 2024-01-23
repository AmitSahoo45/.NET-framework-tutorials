namespace ClassesInCSharp
{
    class Person
    {
        public int age = 10;

        public Person()
        {
            System.Console.WriteLine("I am a person");
        }
    }
    class UsingClass
    {
        public static void main(string[] args)
        {
            var person = new Person();
        }
    }
}