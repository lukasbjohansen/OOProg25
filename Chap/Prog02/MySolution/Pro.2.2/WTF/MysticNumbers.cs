
public class MysticNumbers
{
    #region Methods
    public static int ThreeNumbers(int a, int b, int c)
    {
        return TwoNumbers(TwoNumbers(a, b), c);
    }
    public static int TwoNumbers(int a, int b) {
        return a > b ? a : b;
    }
    public static int FourNumbers(int a, int b, int c, int d) {
        return TwoNumbers(TwoNumbers(TwoNumbers(a,b),c),d);
    }
    public static int AnyNumbers(params int[] numbers) {
        int result = numbers[0]; // numbers may be negative
        foreach (int number in numbers){
            result = number > result ? number : result;
        }
        return result;
    }
    #endregion
}
