
double rect1x1 = 4.5;
double rect1y1 = 2.3;
double rect1x2 = 8.2;
double rect1y2 = 4.9;

double area1 = AreaOfRectangle(rect1x1,rect1y1,rect1x2,rect1y2);
Console.WriteLine($"Area of first rectangle is {area1}");

double rect2x1 = -3.2;
double rect2y1 = 1.1;
double rect2x2 = 3.7;
double rect2y2 = 5.6;

double area2 = AreaOfRectangle(rect2x1,rect2y1,rect2x2,rect2y2);
Console.WriteLine($"Area of second rectangle is {area2}");


double AreaOfRectangle(double x1, double y1, double x2, double y2) {
    // Implement AreaOfRectangle, such that it returns the area
    // of a rectangle defined by (x1, y1) and (x2, y2)
    double area = Math.Abs((x1 - x2) * (y1 - y2));
    return area;
}

double PerimiterLengthOfPentagon(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4, double x5, double y5) {
    double side1 = LengthOfLineSegment(x1, y1, x2, y2);
    double side2 = LengthOfLineSegment(x2, y2, x3, y3);
    double side3 = LengthOfLineSegment(x3, y3, x4, y4);
    double side4 = LengthOfLineSegment(x4, y4, x5, y5);
    double side5 = LengthOfLineSegment(x5, y5, x1, y1);
    double perimeter = side1 + side2 + side3 + side4 + side5;
    return perimeter;
}
double LengthOfLineSegment(double x1, double y1, double x2, double y2) {
    double length = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
    return length;
}
double PerimiterOfPolygon(params (double x, double y)[] points) {
    double perimeter = 0.0;
    for (int i = 0; i < points.Length; i++) {
        (double x1, double y1) = points[i];
        (double x2, double y2) = points[(i + 1) % points.Length];
        perimeter += LengthOfLineSegment(x1, y1, x2, y2);
    }
    return perimeter;
}