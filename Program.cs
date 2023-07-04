namespace Day3PracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Constructor Problem");
            Console.WriteLine("Choose 1 program from below list:");
            Console.WriteLine("\n1.Constructor \n2.Interface \n3.AccessSpecifiers");
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
                case 2:
                    Interface1 dog = new Dog();
                    Interface1 cat = new cat();
                    dog.MakeSound();
                    cat.MakeSound();
                    Console.ReadLine();
                    break;
                case 3:
                    AccessSpecifiers access = new AccessSpecifiers("Bali", 24, "Ravet");
                    Console.WriteLine("Person Details:");
                    Console.WriteLine("Age: " + access.age);
                    access.DisplayPublicInfo();
                    Console.WriteLine();
                    Console.ReadLine();

                    break;

            }
        }
    }
}