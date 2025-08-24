
public class BankAccount
{
    /// <summary>
    /// Balance of the account; must not become negative
    /// </summary>
    public double Balance { get; private set; }

    /// <summary>
    /// Interest rate of the account; must be between 0.0 and 20.0
    /// </summary>
    public double InterestRate { get; }

    public BankAccount(double interestRate)
    {
		if (interestRate < 0.0 || interestRate > 20.0)
		{
			throw new ArgumentException($"In Constructor: Interest rate was {interestRate} % (must be between 0 and 20 %)");
		}

		InterestRate = interestRate;
        Balance = 0.0;
    }

    public void Deposit(double amount)
    {
		if (amount < 0)
		{
			throw new ArgumentException($"In Deposit: Amount was {amount} kr. (negative amount not allowed)");
		}

		Balance = Balance + amount;
    }

    public void Withdraw(double amount)
    {
		if (amount < 0)
		{
			throw new ArgumentException($"In Withdraw: Amount was {amount} kr. (negative amount not allowed)");
		}

		if (Balance < amount)
        {
            throw new ArgumentException($"In Withdraw: Amount was {amount} kr., balance was {Balance} kr.");
        }

        Balance = Balance - amount;
    }
}