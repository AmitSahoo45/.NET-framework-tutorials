
namespace TypeConversion
{
    internal class Program
    {
        public static void main(string[] args)
        {
            byte b = 1;
            int i = b;
            System.Console.WriteLine(i);
            
            int i = 1;
            byte b = (byte) i;
            System.Console.WriteLine(b);
            
            var number = "1234";
            int i = Convert.ToInt32(number);
            System.Console.WriteLine(i);
            
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                System.Console.WriteLine(b);
            }
            catch (Exception)
            {
                System.Console.WriteLine("The number could not be converted to a byte.");
            }
            
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                System.Console.WriteLine(b);
            }
            catch (Exception)
            {
                System.Console.WriteLine("The string could not be converted to a boolean.");
            }
        }
    }

    class Variables{
        byte b = 1000;
    }
}