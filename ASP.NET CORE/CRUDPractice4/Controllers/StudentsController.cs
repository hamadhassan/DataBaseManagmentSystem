using CRUDPractice4.Data;
using CRUDPractice4.Models.Domain;
using CRUDPractice4.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDPractice4.Controllers

{
	public class StudentsController : Controller
	{
		private readonly dbCRUDPractice dbCRUDPractice;

		public StudentsController(dbCRUDPractice dbCRUDPractice)
		{
			this.dbCRUDPractice = dbCRUDPractice;
		}
		[HttpGet]
		public IActionResult Add()
		{
			return View();
		}
		[HttpPost]
		public async Task<IActionResult> Add(AddStudent addStudent)
		{
			var student = new Students()
			{
				Id = Guid.NewGuid(),
				Name = addStudent.Name,
				Description = addStudent.Description
			};
			await dbCRUDPractice.Students.AddAsync(student);
			await dbCRUDPractice.SaveChangesAsync();
			return RedirectToAction("Add");
		}

	}
}
