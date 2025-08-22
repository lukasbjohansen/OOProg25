using RosBilRP.Models;

namespace RosBilRP.Services;

public interface IUserRepository : IRepository<User>
{
	User? VerifyUser(string providedUserName, string providedPassword);
	List<string> Roller { get; }
}

