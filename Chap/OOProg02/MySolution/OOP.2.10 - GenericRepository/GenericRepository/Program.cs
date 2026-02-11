
Repository<string, Car> cars = new Repository<string, Car>();

Car c1 = new Car("AB 12 345", 80000);
Car c2 = new Car("CD 34 456", 65000);
Car c3 = new Car("EF 56 567", 28000);

cars.Insert(c1.LicensePlate, c1);
cars.Insert(c2.LicensePlate, c2);
cars.Insert(c3.LicensePlate, c3);


Repository<string, Employee> employees = new Repository<string, Employee>();

Employee e1 = new Employee("Allan", 1962);
Employee e2 = new Employee("Bente", 1975);
Employee e3 = new Employee("Carlo", 1973);

employees.Insert(e1.Name, e1);
employees.Insert(e2.Name, e2);
employees.Insert(e3.Name, e3);

Repository<string, Computer> computers = new Repository<string, Computer>();

Computer comp1 = new Computer("dh209n", "Microsoft Edge");
Computer comp2 = new Computer("dh210n", "Google Chrome");
Computer comp3 = new Computer("dh211", "Mozilla Firefox");

computers.Insert(comp1.SerialNo, comp1);
computers.Insert(comp2.SerialNo, comp2);
computers.Insert(comp3.SerialNo, comp3);

Repository<string, Phone> phones = new Repository<string, Phone>();

Phone p1 = new Phone("dh209n", 6999);
Phone p2 = new Phone("dh210n", 4999);
Phone p3 = new Phone("dh211", 2999);

phones.Insert(p1.SerialNo, p1);
phones.Insert(p2.SerialNo, p2);
phones.Insert(p3.SerialNo, p3);
