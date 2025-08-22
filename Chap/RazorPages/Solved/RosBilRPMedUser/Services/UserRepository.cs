using Microsoft.AspNetCore.Identity;
using RosBilRP.Models;

namespace RosBilRP.Services;

public class UserRepository : EFCRepositoryBase<User, RosBilDBContext>, IUserRepository
{
	private PasswordHasher<string> _passwordHasher;

	public UserRepository()
	{
		_passwordHasher = new PasswordHasher<string>();
	}

	public List<string> Roller
	{
		get { return new List<string> { "admin", "ansat" }; }
	}

	public override int Create(User user)
	{
		user.Password = _passwordHasher.HashPassword(user.Navn, user.Password);
		return base.Create(user);
	}

	public User? VerifyUser(string providedUserName, string providedPassword)
	{
		// List<User> allUsers = All;

		List<User> users = new List<User>();

		using RosBilDBContext context = new RosBilDBContext();

		users = context.Users.ToList();


		User? user = users.FirstOrDefault(u => u.Navn == providedUserName &&
											   u.Password == providedPassword);

		return user;
	}

	private bool VerifyPassword(User user, string providedPassword)
	{
		PasswordVerificationResult result = _passwordHasher.VerifyHashedPassword(
			user.Navn, user.Password, providedPassword);

		return result == PasswordVerificationResult.Success;
	}

	//private bool VerifyPassword(User user, string providedPassword)
	//{
	//	return user.Password == providedPassword;
	//}
}
