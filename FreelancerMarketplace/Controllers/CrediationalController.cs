using FreelancerMarketplace.Data;
using FreelancerMarketplace.Models.Domain;
using FreelancerMarketplace.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client.Platforms.Features.DesktopOs.Kerberos;

namespace FreelancerMarketplace.Controllers
{
	public class CrediationalController: Microsoft.AspNetCore.Mvc.Controller
    {
		private readonly FreelancerMarketplaceDbContext freelancerMarketplaceDbContext;

		public CrediationalController(FreelancerMarketplaceDbContext freelancerMarketplaceDbContext) 
		{
			this.freelancerMarketplaceDbContext = freelancerMarketplaceDbContext;
		}
		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Add(AddCrediational addCrediational)
		{
			var crediational = new Crediational()
			{
				Id= Guid.NewGuid(),
				Email= addCrediational.Email,
				Password= addCrediational.Password,
				Role=addCrediational.Role
			};
			await freelancerMarketplaceDbContext.AddAsync(crediational);
			await freelancerMarketplaceDbContext.SaveChangesAsync();
			return RedirectToAction("Add");
		}


	}
}
