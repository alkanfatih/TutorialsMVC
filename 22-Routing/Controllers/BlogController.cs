using Microsoft.AspNetCore.Mvc;

namespace _22_Routing.Controllers
{
    public class BlogController : Controller
    {
        [Route("blog/{entryId}/{slug}")]
        public IActionResult Blog(int entryId, string slug)
        {
            return Content($"Blog ID #{entryId} requested (URL Slug: {slug})");
        }

        //[Route("blog/{entryId}/{*slug}")]
        //public IActionResult Blog(int entryId, string slug)
        //{
        //    return Content($"Blog ID #{entryId} requested (URL Slug: {slug})");
        //}

        //[Route("blog/{entryId}/{slug?}")]
        //public IActionResult Blog(int entryId, string slug)
        //{
        //    return Content($"Blog ID #{entryId} requested (URL Slug: {slug})");
        //}
        //[Route("blog/{entryId:range(1, 999999)}/{slug}")]
        //public IActionResult Blog(int entryId, string slug)
        //{

        //    return View();
        //    //...
        //}
    }
}
