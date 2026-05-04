using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Welcome to Islam's Carpet Cleaning Service");
//Charges: $250 per small   $350 per large Sales tax rate is 14% Estimates are valid for 30 days
int smallCarpetsprice= 250;
int largeCarpetsprice = 350;
double salesTaxRate = 0.14;
string estimateValidity = "Estimates are valid for 30 days";

Console.WriteLine("Enter the Number Of Carpets");

Console.Write("Enter the Number Of  small Carpets:");
int smallCarpets = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the Number Of  large Carpets:");
int largeCarpets = Convert.ToInt32(Console.ReadLine());

int cost = (smallCarpets * smallCarpetsprice) + (largeCarpets * largeCarpetsprice);
double tax = cost * salesTaxRate;
double total = cost + tax;

Console.WriteLine("=================================================");
Console.WriteLine("Estimate for carpet cleaning service:");
Console.WriteLine($"Number of small carpets: {smallCarpets}");
Console.WriteLine($"Number of large carpets: {largeCarpets}");
Console.WriteLine($"Cost: ${cost}");
Console.WriteLine($"Tax: ${tax}");
Console.WriteLine("=================================================");
Console.WriteLine($"Total estimate: ${total}");
Console.WriteLine(estimateValidity);







