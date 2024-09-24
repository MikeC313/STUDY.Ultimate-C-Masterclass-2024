Console.WriteLine("Hello!");

bool shallExit = false;
while (!shallExit)
{
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "s":
        case "S":
            Console.WriteLine("See all TODOs");
            break;
        case "a":
        case "A":
            Console.WriteLine("Add a TODO");
            break;
        case "r":
        case "R":
            Console.WriteLine("Remove a TODO");
            break;
        case "e":
        case "E":
            shallExit = true;
            break;
        default:
            Console.WriteLine("Invalid choice");
            break;
    }
}
Console.ReadKey();