
public class Rectangle : Shape
{
    #region Properties
    public double XLowerLeft { get; }
    public double YLowerLeft { get; }
    public double XUpperRight { get; }
    public double YUpperRight { get; }
    public double Width { get { return Math.Abs(XLowerLeft - XUpperRight); } }
    public double Height { get { return Math.Abs(YLowerLeft - YUpperRight); } }
	#endregion

	#region Constructor
	public Rectangle(double xLowerLeft, double yLowerLeft, double xUpperRight, double yUpperRight)
        : base("Rectangle")
    {
        XLowerLeft = xLowerLeft;
        YLowerLeft = yLowerLeft;
        XUpperRight = xUpperRight;
        YUpperRight = yUpperRight;
    }
    #endregion

    /// <summary>
    /// Override of base class (abstract) property
    /// </summary>
    public override double Area { get { return Width * Height; } }
}