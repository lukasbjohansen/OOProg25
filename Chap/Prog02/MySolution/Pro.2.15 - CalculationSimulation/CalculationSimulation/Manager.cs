/// <summary>
/// This class manages the execution of a calculation simulation
/// </summary>
public class Manager
{
    const int MAX_X = 5;
    const int MAX_Y = 5;
    /// <summary>
    /// Runs the simulation
    /// </summary>
    public static void Run()
    {
        Simulator theSimulator = new Simulator(MAX_X, MAX_Y);
        Random theGenerator = new Random();

        // Runs the simulation 1000 times
        for (int iteration = 0; iteration < 1000; iteration++)
        {
            int x = theGenerator.Next(0, MAX_X);
            int y = theGenerator.Next(0, MAX_Y);
            int? value = theSimulator.Calculate(x, y);
            Console.WriteLine($"Iteration {iteration:000} :   ({x},{y}) => {value}");
        }
    }
}
