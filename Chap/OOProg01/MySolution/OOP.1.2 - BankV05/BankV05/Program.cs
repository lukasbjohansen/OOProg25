/*
 * OOP.1.2 Solution by Lukas Johansen
 */
BankAccount myAccount = new BankAccount("Lukas");

Console.WriteLine($"Account holder is : {myAccount.AccountHolder}");

myAccount.Deposit(2000);
Console.WriteLine($"Account balance is : {myAccount.Balance}");

myAccount.Withdraw(1500);
Console.WriteLine($"Account balance is : {myAccount.Balance}");
