Console.WriteLine("Are you coming or leaving? (in/out):");
string userchoise = Console.ReadLine();

if (userchoise == "in")
{
    PrintHello();
}
else
{
    printgoodbye();
}


 



static void PrintHello() //Function ehk meetod
{
    Console.WriteLine("Hello, world!");
}

static void printgoodbye()
{
    Console.WriteLine("See you later, aligator!");
}