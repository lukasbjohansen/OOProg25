public class RNG {
	private static Random _random = new Random();
	/// <summary>Returns a random integer that is within a specified range.</summary>
	/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
	/// <param name="maxValue">The exclusive upper bound of the random number returned. <paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.</param>
	/// <returns>
	/// A 32-bit signed integer greater than or equal to <paramref name="minValue"/> and less than <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
	/// but not <paramref name="maxValue"/>. If minValue equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
	/// </returns>
	/// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
	public static int Next(int minValue, int maxValue) {
		return _random.Next(minValue, maxValue);
	}
	/// <summary>Returns a random integer that is within a specified range.</summary>
	/// <param name="minValue">The inclusive lower bound of the random number returned.</param>
	/// <param name="maxValue">The inclusive upper bound of the random number returned. <paramref name="maxValue"/> must be greater than or equal to <paramref name="minValue"/>.</param>
	/// <returns>
	/// A 32-bit signed integer greater than or equal to <paramref name="minValue"/> and less than or equal to <paramref name="maxValue"/>; that is, the range of return values includes <paramref name="minValue"/>
	/// and <paramref name="maxValue"/>. If minValue equals <paramref name="maxValue"/>, <paramref name="minValue"/> is returned.
	/// </returns>
	/// <exception cref="ArgumentOutOfRangeException"><paramref name="minValue"/> is greater than <paramref name="maxValue"/>.</exception>
	public static int NextIncl(int minValue, int maxValue) {
		return _random.Next(minValue, maxValue + 1);
	}
	//
	// Summary:
	//     Returns a non-negative random integer that is less than the specified maximum.
	//
	//
	// Parameters:
	//   maxValue:
	//     The exclusive upper bound of the random number to be generated. maxValue must
	//     be greater than or equal to 0.
	//
	// Returns:
	//     A 32-bit signed integer that is greater than or equal to 0, and less than maxValue;
	//     that is, the range of return values ordinarily includes 0 but not maxValue. However,
	//     if maxValue equals 0, 0 is returned.
	//
	// Exceptions:
	//   T:System.ArgumentOutOfRangeException:
	//     maxValue is less than 0.
	public static int Next(int maxValue) {
		return _random.Next(maxValue);
	}
}
