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
            var gateway = new SearchBlogPostsGateway();
            var usecase = new SearchBlogPosts(gateway);

            var outputboundary = new SearchBlogPostOutputBoundary();
            usecase.Execute(new SearchBlogPostsRequest(search,nRecords,page), outputboundary);

            if(outputboundary.Success)
                return Json(outputboundary.Result);
            return StatusCode(500, outputboundary.ErrorMessage);
        }
    }
}