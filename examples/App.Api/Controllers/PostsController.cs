using App.Api.Extensions;
using App.Core.UseCases.SearchBlogPosts;
using FD.CleanArchitecture.Core.Interactor;
using Microsoft.AspNetCore.Mvc;
using System;

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
            var usecase = _factory.Create<SearchBlogPostsRequest, SearchBlogPostsResponse>();

            try
            {
                var viewModel = usecase.Execute(new SearchBlogPostsRequest(search, nRecords, page)).ToViewModel();
                return Json(viewModel);
            }
            catch (Exception e)
            {
                return StatusCode(500, e);
            }
           
        }
    }
}