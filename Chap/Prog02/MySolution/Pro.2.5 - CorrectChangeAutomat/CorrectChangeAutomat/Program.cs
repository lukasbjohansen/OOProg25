
int price = 266;
int paidAmount = 500;	
int change = paidAmount - price;

int change500 = change / 500;
change %= 500;
int change200 = change / 200;
change %= 200;
int change100 = change / 100;
change %= 100;
int change50 = change / 50;
change %= 50;
int change20 = change / 20;
change %= 20;
int change10 = change / 10;
change %= 10;
int change5 = change / 5;
change %= 5;
int change2 = change / 2;
change %= 2;
int change1 = change / 1;
change %= 1;


Console.WriteLine($"Total change of {paidAmount - price} recieved as:");
if (change500 > 0) Console.WriteLine($"{change500} 500kr.");
if (change200 > 0) Console.WriteLine($"{change200} 200kr.");
if (change100 > 0) Console.WriteLine($"{change100} 100kr.");
if (change50 > 0) Console.WriteLine($"{change50} 50kr.");
if (change20 > 0) Console.WriteLine($"{change20} 20kr.");
if (change10 > 0) Console.WriteLine($"{change10} 10kr.");
if (change5 > 0) Console.WriteLine($"{change5} 5kr.");
if (change2 > 0) Console.WriteLine($"{change2} 2kr.");
if (change1 > 0) Console.WriteLine($"{change1} 1kr.");

