/*
 * Pro.1.2 solution by Lukas Johansen
 */

// Trying to write line with another input than string (works)
Console.WriteLine("Test of writeline with other input than string:");
Console.WriteLine(false);
Console.WriteLine();
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine();

// Default prices
double netPriceBook = 30;
double netPriceDVD = 50;
double netPriceGame = 100;

// Amounts of items in the order
int noOfBooksInOrder = 23;
int noOfDVDsInOrder = 16;
int noOfGamesInOrder = 7;

// Calculations
double totalNetPrice = netPriceBook * noOfBooksInOrder + netPriceDVD * noOfDVDsInOrder + netPriceGame * noOfGamesInOrder;
Console.WriteLine($"The total netprice of the order is: {totalNetPrice} kr.");
Console.WriteLine();

// Tax
Console.WriteLine("TAX:");
double taxRate = 0.1;
Console.WriteLine($"The tax rate is: {taxRate*100}%");
double taxAmount = totalNetPrice * taxRate;
Console.WriteLine($"The tax amount for the order is: {taxAmount} kr.");
double priceIncludingTax = totalNetPrice + taxAmount;
Console.WriteLine($"The total price after tax is: {priceIncludingTax} kr.");
Console.WriteLine();

// Shipping
Console.WriteLine("SHIPPING:");
double shippingCost = 49;
Console.WriteLine($"The cost of shipping is: {shippingCost} kr.");
double priceIncludingShipping = priceIncludingTax + shippingCost;
Console.WriteLine($"The price including shipping is: {priceIncludingShipping} kr.");
Console.WriteLine();

// Credit card fee
Console.WriteLine("CREDIT-CARD FEE:");
double creditCardFeeRate = 0.02;
Console.WriteLine($"The credit-card fee is: {creditCardFeeRate*100}% of the total cost");
double creditCardFee = priceIncludingShipping * creditCardFeeRate;
Console.WriteLine($"The credit-card fee is: {creditCardFee} kr.");
double totalPrice = priceIncludingShipping + creditCardFee;
Console.WriteLine($"The total price including tax, shipping and credit-card fee is: {totalPrice} kr.");
Console.WriteLine();
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine();

// Printing final order summary
Console.WriteLine($"You ordered {noOfBooksInOrder} books, " +
                  $"{noOfDVDsInOrder} DVDs and " +
                  $"{noOfGamesInOrder} games");
Console.WriteLine($"Total cost including tax, shipping and credit card fee: {totalPrice} kr.");
Console.WriteLine();
Console.WriteLine("--------------------------------------------------------------------------");
Console.WriteLine();
