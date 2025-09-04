/*
 * OOP.1.2 Solution by Lukas Johansen
 */

/// <summary>
/// This class represents a very simple bank account.
/// Only the amount of money on the account is represented.
/// </summary>
public class BankAccount
{
    private double _balance;
    private string _accountHolder;

    public BankAccount(string accountHolder)
    {
        _balance = 0.0;
        _accountHolder = accountHolder;
    }

    public double Balance
    {
        get { return _balance; }
    }
    public string AccountHolder
    {
        get { return _accountHolder; }
    }

    public void Deposit(double amount)
    {
        _balance = _balance + amount;
    }

    public void Withdraw(double amount)
    {
        _balance = _balance - amount;
    }
}

