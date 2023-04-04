using CRUDPractice.Data;
using CRUDPractice.Models.Domain;
using CRUDPractice.Models.View;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUDPractice.Controllers
{
    public class StudentController : Controller
    {
        private readonly CRUDPracticeDbContext cRUDPracticeDbContext;

        public StudentController(CRUDPracticeDbContext cRUDPracticeDbContext)
        {
            this.cRUDPracticeDbContext = cRUDPracticeDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddStudent addStudent)
        {
            var student = new Student()
            {
                Id = Guid.NewGuid(),
                FirstName= addStudent.FirstName,
                LastName= addStudent.LastName,
                RegistrationNumber=addStudent.RegistrationNumber,
                PhoneNumber=addStudent.PhoneNumber,
                City=addStudent.City,
                University=addStudent.University,
            };
            await cRUDPracticeDbContext.Students.AddAsync(student);
            await cRUDPracticeDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> ViewStudent()
        {
            var student = await cRUDPracticeDbContext.Students.ToListAsync();
            return View(student);
        }
        [HttpGet]
        public async Task<IActionResult> Update(Guid id)
        {
            var student = await cRUDPracticeDbContext.Students.FirstOrDefaultAsync(x => x.Id == id);
            if (student != null)
            {
                var viewModel = new UpdateStudent()
                {
                    Id = student.Id,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    RegistrationNumber = student.RegistrationNumber,
                    PhoneNumber = student.PhoneNumber,
                    City = student.City,
                    University = student.University,
                };
                return await Task.Run(() => View("Update", viewModel));
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Update(UpdateStudent viewModel)
        {
            var student = await cRUDPracticeDbContext.Students.FindAsync(viewModel.Id);
            if (student != null)
            {
                student.Id = viewModel.Id;
                student.FirstName = viewModel.FirstName;
                student.LastName = viewModel.LastName;
                student.RegistrationNumber = viewModel.RegistrationNumber;
                student.PhoneNumber = viewModel.PhoneNumber;
                student.City = viewModel.City;
                student.University = viewModel.University;
                await cRUDPracticeDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(UpdateStudent viewModel)
        {
            var student = await cRUDPracticeDbContext.Students.FindAsync(viewModel.Id);
            if (student != null)
            {
                cRUDPracticeDbContext.Students.Remove(student);
                await cRUDPracticeDbContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }
      

    }
}
