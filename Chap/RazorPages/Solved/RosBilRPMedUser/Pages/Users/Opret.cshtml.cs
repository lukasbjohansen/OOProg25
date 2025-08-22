using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RosBilRP.Models;
using RosBilRP.Services;

namespace RosBilRP.Pages.Users;

[Authorize(Roles = "admin")]
public class OpretModel : PageModel
{
	private IUserRepository _repo;

	[BindProperty]
	public User Element { get; set; } = new User();

	public SelectList Roller { get; set; }

	public OpretModel(IUserRepository repo)
	{
		_repo = repo;

		Roller = new SelectList(_repo.Roller);
	}

	public IActionResult OnPost()
	{
		// Tjek om det indtastede data er validt
		if (!ModelState.IsValid)
		{
			return Page();
		}

		// Send data videre til repository
		_repo.Create(Element);

		// Vend tilbage til startsiden
		return RedirectToPage("/Index");
	}
}

