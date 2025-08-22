// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string carModel = "Focus";

string carManufacturer = carModel switch
{
    "Patriot" or "Liberty" or "Wrangler" => "Jeep",
    "Focus" => "Ford",
    "Corolla" => "Toyota",
    _ => "unknown"
};

// switch (carModel)
// {
//     case "Patriot":
//     case "Liberty":
//     case "Wrangler":
//         carManufacturer = "Jeep";
//         break;
//     case "Focus":
//         carManufacturer = "Ford";
//         break;
//     case "Corolla":
//         carManufacturer = "Toyota";
//         break;
//     default:
//         carManufacturer = "unknown";
//         break;
// }

Console.WriteLine($"Manufacturer is {carManufacturer}");


// For Loops
int j = 10;

for (int i = 1; i < 50; i++)
{
    j += j;
    Console.WriteLine("j = "+j);
    Console.WriteLine("i = "+i);
    if(j > 100)
        break;
}
        
