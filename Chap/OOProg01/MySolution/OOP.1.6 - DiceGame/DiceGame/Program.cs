/*
 * OOP.1.6 solution by Lukas Johansen
 */

// Testing of the DiceCup method and property
DiceCup cup = new DiceCup(6,6,10);
Console.WriteLine(cup.TotalValue);
cup.Shake();
Console.WriteLine(cup.TotalValue);