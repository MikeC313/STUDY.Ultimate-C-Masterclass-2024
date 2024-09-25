var todos = new List<string>();

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
            AddTodo();
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

void AddTodo()
{
    bool isValidDescription = false;
    while (!isValidDescription)
    {
        Console.WriteLine("Enter the TODO description:");
        var description = Console.ReadLine();

        if (description == "")
        {
            Console.WriteLine("The description cannot be empty");
        }
        else if (todos.Contains(description))
        {
            Console.WriteLine("The description must be unique");
        }
        else
        {
            isValidDescription = true;
            todos.Add(description);
        }
    }
}