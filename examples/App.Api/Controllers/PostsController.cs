using App.Api.OutputBoundaries;
using App.Core.UseCases.SearchBlogPosts;
using App.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Posts")]
    public class PostsController : Controller
    {

        [HttpGet]
        public IActionResult GetAllPosts([FromQuery]string search,[FromQuery]int? nRecords = null,[FromQuery]int? page=null)
        {
            var outputboundary = new SearchBlogPostOutputBoundary();
            var gateway = new SearchBlogPostsGateway();
            var usecase = new SearchBlogPosts(outputboundary,gateway);
            usecase.Execute(new SearchBlogPostsRequest(search,nRecords,page));

            if(outputboundary.Success)
                return Json(outputboundary.Result);
            return StatusCode(500, outputboundary.ErrorMessage);
        }
    }
}