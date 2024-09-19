public interface UCalculator
{
    /// <summary>
    /// Add method, adds two numbers together
    /// </summary>
    /// <param name="a">value a</param>
    /// <param name="b">value b</param>
    /// <returns>sum of a +b</returns>
    double Add(double a, double b);
    /// <summary>
    /// Subtract method, subtracts one number from another
    /// </summary>
    /// <param name="a">value a</param>
    /// <param name="b">value b</param>
    /// <returns>sum of a - b</returns>
    
    double Subtract(double a, double b);
    /// <summary>
    /// mutiply method, multiplies one num
    /// </summary>
    /// <param name="a">value a</param>
    /// <param name="b">value b</param>
    /// <returns>sum of a*b</returns>
    double Multiply (double a, double b);

    /// <summary>
    /// Devides one number with another
    /// </summary>
    /// <param name="a">value a</param>
    /// <param name="b">value b</param>
    /// <returns>sum of a/b</returns>
    double Devide (double a, double b);
}