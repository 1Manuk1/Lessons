{


    int sum = 0;

    for (int i = 1; i <= 100; i++)
    {
        sum += i;
    }

    Console.WriteLine("The sum of numbers from 1 to 100 is: " + sum);

}

{
    {
        int sum = 0;
        int i = 1;

        while (i <= 100)
        {
            sum += i;
            i++;
        }

        Console.WriteLine("The sum of numbers from 1 to 100 is: " + sum);
    }
}

{
    {
        int sum = 0;
        int i = 1;

        do
        {
            sum += i;
            i++;
        } while (i <= 100);

        Console.WriteLine("The sum of numbers from 1 to 100 is: " + sum);
    }
}