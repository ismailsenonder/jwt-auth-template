using JwtTest.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtTest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        readonly INewsService newsService;

        public NewsController(INewsService newsService) => this.newsService = newsService;

        [HttpGet("GetLatest")]
        [AllowAnonymous]
        public string GetLatestNews()
        {
            return newsService.GetLatestNews();
        }

        [HttpGet("GetLatestPaid")]
        [Authorize]
        public string GetLatestNewsPaid()
        {
            return newsService.GetLatestNewsPaid();
        }
    }
}
