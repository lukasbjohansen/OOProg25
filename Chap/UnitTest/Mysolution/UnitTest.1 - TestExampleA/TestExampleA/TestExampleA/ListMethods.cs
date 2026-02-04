
public class ListMethods
{
    /// <summary>
    /// This method calculates the sum of the squares of the
    /// positive numbers in the list. 
    /// Examples: [2, 3, 5] = 2x2 + 3x3 + 5x5 = 4 + 9 + 25 = 38
    ///           [4, -2, 3] = 4x4 + 3x3 = 16 + 9 = 25 (-2 was excluded)
    /// If a null value or an empty list is given as parameter,
    /// the exception ArgumentException is thrown 
    /// </summary>
    public int SumOfSquaresOfPositives(List<int> numbers)
    {
        int sum = 0;
        int prevSum = sum;
        const int SQR_ROOT_OF_INT_LIM = 46340;

		if (numbers == null)
            throw new ArgumentException("The list cannot be null");
        if (numbers.Count == 0)
            throw new ArgumentException("The list was empty");
        foreach (int n in numbers)
        {
            if (n > 0)
            {
                if (n > SQR_ROOT_OF_INT_LIM)
					throw new OverflowException();
				sum += n * n;
                if (sum < prevSum)
                    throw new OverflowException();
                prevSum = sum;
			}
        }
        return sum;
    }
}
