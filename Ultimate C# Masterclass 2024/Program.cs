//bool isParsingSuccessful;
//do
//{
// 56. TryParse METHOD  
//
//    Console.WriteLine("Enter a number:");
//    var userInput = Console.ReadLine();

//    isParsingSuccessful = int.TryParse(
//        userInput, out int number);
//    if (isParsingSuccessful)
//    {
//        Console.WriteLine("Parsing worked, number is " + number);
//    }
//    else
//    {
//        Console.WriteLine("Parsing was not successful");
//    }
//} while (!isParsingSuccessful);

//Console.ReadKey();

//Console.WriteLine("Enter a number:");
//var userInput = Console.ReadLine();

//bool isParsingSuccessful = int.TryParse(
//    userInput, out int number);

//if(isParsingSuccessful)
//{
//    Console.WriteLine("Parsing worked, number is " + number);
//}
//else
//{
//    Console.WriteLine("Parsing was not successful");
//}

//Console.ReadKey();

// 55 OUT KEYWORD

//var numbers = new[] { 10, -8, 2, 12, -17 };
//int nonPositiveCount;
//var onlyPositive = GetOnlyPositive(numbers, out nonPositiveCount);
//foreach (var positiveNumber in onlyPositive)
//{
//    Console.WriteLine(positiveNumber);
//}
//Console.WriteLine("Count of non positive: " + nonPositiveCount);
//Console.ReadKey();

//List<int> GetOnlyPositive(
//    int[] numbers, out int countOfNonPositive)
//{
//    countOfNonPositive = 0;
//    var result = new List<int>();

//    foreach (int number in numbers)
//    {
//        if (number > 0)
//        {
//            result.Add(number);
//        }
//        else
//        {
//            countOfNonPositive++;
//        }
//    }
//    return result;
//}


// CODING EXERCISE 14 LISTS GetOnlyUpperCaseWords

//List<string> GetOnlyUpperCaseWords(List<string> words)
//{
//    var result = new List<string>();
//    foreach(var word in words)
//    {
//        if(result.Contains(word))
//        {
//            continue;
//        }
//        if(IsUpperCase(word))
//        {
//            result.Add(word);
//        }
//    }
//    return result;
//}

//bool IsUpperCase(string word)
//{
//    foreach (char letter in word)
//    {
//        if (!char.IsUpper(letter))
//        {
//            return false;
//        }
//    }
//    return true;
//}

//Console.ReadKey();

// 54. Lists
//var words = new List<string>
//{
//    "one",
//    "two",
//};

//Console.WriteLine("Count of elements is " + words.Count);
//foreach (var word in words)
//{
//    Console.WriteLine(word);
//}

//Console.ReadKey();