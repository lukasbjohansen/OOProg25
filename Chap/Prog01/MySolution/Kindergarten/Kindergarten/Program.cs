/*
 * Lab: Kindergarten project by Lukas Johansen
 */

// Known variables
// Fruit prices
double applePrice = 1;
double pearPrice = 3;
double bananaPrice = 4;

// Input
int childrenCount = 10;
int applesDelivered = 23;
int pearsDelivered = 19;
int bananasDelivered = 40;

// Calculated variables
// Apples
int appleCountPerChild = applesDelivered / childrenCount;
int remainingAppleCount = applesDelivered % childrenCount;
double remainingApplePrice = remainingAppleCount * applePrice;
// Pears
int pearCountPerChild = pearsDelivered / childrenCount;
int remainingPearCount = pearsDelivered % childrenCount;
double remainingPearPrice = remainingPearCount * pearPrice;
// Bananas
int bananaCountPerChild = bananasDelivered / childrenCount;
int remainingBananaCount = bananasDelivered % childrenCount;
double remainingBananaPrice = remainingBananaCount * bananaPrice;
// Total
double totalPrice = remainingApplePrice + remainingPearPrice + remainingBananaPrice;

// Print
Console.WriteLine();
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine($"There are {childrenCount} children today.");
Console.WriteLine("Today the following fruits were delivered:");
Console.WriteLine($"Apples: {applesDelivered}");
Console.WriteLine($"Pears: {pearsDelivered}");
Console.WriteLine($"Bananas: {bananasDelivered}");
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("Each child will get:");
Console.WriteLine($"{appleCountPerChild} apples,");
Console.WriteLine($"{pearCountPerChild} pears and");
Console.WriteLine($"{bananaCountPerChild} bananas.");
Console.WriteLine("And there will be:");
Console.WriteLine($"{remainingAppleCount} apples,");
Console.WriteLine($"{remainingPearCount} pears and");
Console.WriteLine($"{remainingBananaCount} bananas.");
Console.WriteLine("Left for the employees to buy.");
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine("PRICES");
Console.WriteLine($"Apples: {applePrice} kr. each");
Console.WriteLine($"Pears: {pearPrice} kr. each");
Console.WriteLine($"Bananas: {bananaPrice} kr. each");
Console.WriteLine("For all:");
Console.WriteLine($"Apples: there are {remainingAppleCount} apples left with a total price of {remainingApplePrice} kr.");
Console.WriteLine($"Pears: there are {remainingPearCount} pears left with a total price of {remainingPearPrice} kr.");
Console.WriteLine($"Bananas: there are {remainingBananaCount} bananas left with a total price of {remainingBananaPrice} kr.");
Console.WriteLine($"The price of all remaining fruit is {totalPrice} kr.");
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine();