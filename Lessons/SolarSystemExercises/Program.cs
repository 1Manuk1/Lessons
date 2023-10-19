// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
{
    {
        string planet;

        Console.WriteLine("Enter a planet name:");
        planet = Console.ReadLine();


        switch (planet)
        {
            case "Mercury":
                Console.WriteLine("The distance from the sun is 57,900,000km, the color is slate gray");
                break;
            case "Venus":
                Console.WriteLine("The distance from the sun is 108,200,000km, the color is pearly white");
                break;
            case "Earth":
                Console.WriteLine("The distance from the sun is 149,600,000km, the color is vibrant blue");
                break;
            case "Mars":
                Console.WriteLine("The distance from the sun is 227,900,000km, the color is dusky red");
                break;
            case "Jupiter":
                Console.WriteLine("The distance from the sun is 778,600,000km, the color is beige with brilliant red-brown belts");
                break;
            case "Saturn":
                Console.WriteLine("The distance from the sun is 778,600,000km, the color is beige with brilliant red-brown belts");
                break;
            case "Uranus":
                Console.WriteLine("The distance from the sun is 2,872,500,000km, the color is opaque blue");
                break;
            case "Neptune":
                Console.WriteLine("The distance from the sun is 4,495,100,000km, the color is opaque blue");
                break;
            default:
                break;
        }
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
