namespace Inheritance
{
    public class ParentClass
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Copy method from ParentClass");
        }

        public void Duplicate()
        {
            Console.WriteLine("Duplicate from ParentClass");
        }
    }

    public class ChildClass : ParentClass
    {
        public int Fontsize { get; set; }
        public int Fontname { get; set; }

        public void HyperLink(string url)
        {
            Console.WriteLine("URL - {0}", url);
        }
    }

    internal class Program()
    {
        static void Main(string[] args)
        {
            var child = new ChildClass();
            child.HyperLink("www.google.com");
        }
    }
}