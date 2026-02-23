
#region Dog objects
using GenericsDogsAndCircles;

Dog dog1 = new Dog("King", 70, 55);
Dog dog2 = new Dog("Spot", 30, 10);
Dog dog3 = new Dog("Rufus", 80, 40);
#endregion

#region Circle objects
Circle c1 = new Circle(10, 2, 3);
Circle c2 = new Circle(15, 6, 0);
Circle c3 = new Circle(8, 12, 7);
#endregion

#region ObjectComparer test
ObjectComparer comparer = new ObjectComparer();
Console.WriteLine(comparer.LargestDog(dog1, dog2, dog3));
Console.WriteLine(comparer.LargestCircle(c1, c2, c3));
Console.WriteLine();

BetterObjectComparer<Dog> dogComparer = new BetterObjectComparer<Dog>();
BetterObjectComparer<Circle> circleComparer = new BetterObjectComparer<Circle>();
Console.WriteLine(dogComparer.Largest(dog1, dog2, dog3));
Console.WriteLine(circleComparer.Largest(c1, c2, c3));
Console.WriteLine();

EvenBetterObjectComparer comparer2 = new EvenBetterObjectComparer();
Console.WriteLine(comparer2.Largest(dog1, dog2, dog3,new DogCompareByHeight()));
Console.WriteLine(comparer2.Largest(c1, c2, c3,new CircleCompareByX()));
Console.WriteLine();

#endregion
