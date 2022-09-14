namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cn = "Tom";
            int ca;
            ca = 25;

            Console.WriteLine($"There once was a man named {cn}");
            Console.WriteLine("He was " +ca+ " years old");

            cn = "Mike";

            Console.WriteLine("He really liked the name " + cn);
            Console.WriteLine($"But didnt like being {ca}");
            
            
            Console.ReadLine();
        }
    }
}