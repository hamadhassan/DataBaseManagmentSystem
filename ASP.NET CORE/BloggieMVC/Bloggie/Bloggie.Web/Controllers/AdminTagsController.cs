using Bloggie.Web.Data;
using Bloggie.Web.Models.Domain;
using Bloggie.Web.Models.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Web.Controllers
{
    public class AdminTagsController : Controller
    {
        private readonly BloggiedbContext bloggiedbContext;

        public AdminTagsController(BloggiedbContext bloggiedbContext) 
        {
            this.bloggiedbContext = bloggiedbContext;
        }

        /// <summary>
        /// Actions
        /// </summary>
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ActionName("Add")]
        public IActionResult Add(AddTagRequest addTagRequest)
        {
            // Mapping AddTagRequest to Tag domain model
            var tag = new Tag
            {
                Name = addTagRequest.Name,
                DisplayName = addTagRequest.DisplayName
            };
            bloggiedbContext.Tags.Add(tag);
            bloggiedbContext.SaveChanges();
            return View("Add");
        }
    }
}
