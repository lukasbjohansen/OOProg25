
PersonRepository personRepository = new PersonRepository();
PersonService personService = new PersonService(personRepository);

try
{
    Console.WriteLine("Trying something...");
    Person p1 = new Person("py",2,500);
    Person p2 = new Person("peter",2,49);
    personService.CreatePerson("", p1.Height, p1.Weight);
	Console.WriteLine("Done, all is well...");
}
catch (ArgumentException arguEx)
{
    Console.WriteLine($"Got an argument Exception!  ->  {arguEx.Message}");
}
catch (RepositoryException repoEx)
{
    Console.WriteLine($"Got a repository Exception!  ->  {repoEx.Message}");
}
catch (Exception ex)
{
    // When the exercise is solved, we should - in theory -  never end up in this case...
    Console.WriteLine($"Got a general Exception!  ->  {ex.Message}");
}
