{
    static void Main()
    {
        List<int> oddNumbers = new();
        List<int> evenNumbers = new List<int>();

        Console.WriteLine("Enter numbers (type 'exit' to finish):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "exit")
                break;

            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                    evenNumbers.Add(number);
                else
                    oddNumbers.Add(number);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number or type 'exit' to finish.");
            }
        }

        Console.WriteLine("Odd numbers: ");
        foreach (var odd in oddNumbers)
        {
            Console.Write(odd + " ");
        }

        Console.WriteLine("\nEven numbers: ");
        foreach (var even in evenNumbers)
        {
            Console.Write(even + " ");
        }
    }
}
