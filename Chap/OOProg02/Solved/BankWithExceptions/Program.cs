
BankAccount? theAccount = null;

// Create a new bank account with 25 % interest rate
// (is that legal...?)
try
{
    theAccount = new BankAccount(25.0);
}
catch (ArgumentException e)
{
    Console.WriteLine("You tried to use an illegal interest rate: " + e.Message);
}


theAccount = new BankAccount(5.0);
theAccount.Deposit(2000);

Console.WriteLine($"Balance is now : {theAccount.Balance}");


try
{
    theAccount.Deposit(-1000);
}
catch (ArgumentException e)
{
    Console.WriteLine("You tried to deposit a negative amount: " + e.Message);
}

Console.WriteLine($"Balance is now : {theAccount.Balance}");


try
{
    theAccount.Withdraw(3000);
}
catch (ArgumentException e)
{
    Console.WriteLine("You tried to withdraw too much money: " + e.Message);
}

Console.WriteLine($"Balance is now : {theAccount.Balance}");
