
public class BankAccount
{
    #region Properties
    public double Balance
    {
        get; private set;
    }
    #endregion

    #region Constructor
    public BankAccount()
    {
        Balance = 0.0;
    }
    #endregion

    #region Methods
    public void Deposit(double amount)
    {
        if (amount > 0) {
			Balance = Balance + amount;
		} else {
			Console.WriteLine("Can only deposit positive amounts");
        }
	}

    public void Withdraw(double amount) {
        if (amount <= Balance) {
            if (amount > 0) {
                Balance = Balance - amount;
            } else {
                Console.WriteLine("Can only withdraw positive amounts");
            }
        } else {
            Console.WriteLine("Insufficient funds");
        }
    }
    #endregion
}
