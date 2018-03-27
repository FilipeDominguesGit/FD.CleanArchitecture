using App.Api.OutputBoundaries;
using App.Core.UseCases;
using App.Core.UseCases.SearchBlogPosts;
using App.Infrastructure;
using FD.CleanArchitecture.Core.Interactor;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [Produces("application/json")]
    [Route("api/Posts")]
    public class PostsController : Controller
    {
        private readonly IInteractorsFactory _factory;

        public PostsController(IInteractorsFactory factory)
        {
            _factory = factory;
        }

        [HttpGet]
        public IActionResult GetAllPosts([FromQuery]string search,[FromQuery]int? nRecords = null,[FromQuery]int? page=null)
        {
           // var gateway = new SearchBlogPostsGateway();
            //var usecase = new SearchBlogPostsInteractor(gateway);

            var usecase = _factory.Create<SearchBlogPostsRequest, SearchBlogPostsResponse>();

            var outputboundary = new SearchBlogPostOutputBoundary();
            usecase.Execute(new SearchBlogPostsRequest(search,nRecords,page), outputboundary);

            if(outputboundary.Success)
                return Json(outputboundary.Result);
            return StatusCode(500, outputboundary.ErrorMessage);
        }
    }
}