
Console.WriteLine("Nothing to see here, move along to the Unit Test...");
Order order = new Order(new List<double> { 12.0, 20.0, 75.0, 44.0, 15.0, 49.0 });
Console.WriteLine($"Total order price: {order.TotalOrderPrice}");
Console.WriteLine($"Total original order price: {order.CalculateTotalOrderPrice()}");