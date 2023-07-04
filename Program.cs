namespace Day3PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Problem");
            Console.WriteLine("Choose 1 program from below list:");
            Console.WriteLine("\n1.Constructor");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Constructor constructor = new Constructor();
                    Constructor constructor2 = new Constructor("Bali", 24);
                    Constructor constructor3 = new Constructor(constructor2);
                    Console.WriteLine(" Default constructor:");
                    constructor.Display();

                    Console.WriteLine("\nParameterized constructor:");
                    constructor2.Display();

                    Console.WriteLine("\nCopy constructor:");
                    constructor3.Display();

                    Console.ReadLine();
               break;

            }
        }
    }
}