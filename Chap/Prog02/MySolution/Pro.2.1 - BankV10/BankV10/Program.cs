
BankAccount account = new BankAccount();
Console.WriteLine($"Balance is {account.Balance}");

account.Deposit(1000);
Console.WriteLine($"Balance is {account.Balance}");

account.Withdraw(1200);
Console.WriteLine($"Balance is {account.Balance}");