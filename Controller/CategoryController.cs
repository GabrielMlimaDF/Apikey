using ApiKey.Attributes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiKey.Controller
{
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet("/v1/categories")]
        [ApiKey]
        public async Task<IActionResult> GetList([FromServices] ContextApp contextApp)
        {
            var categories = await contextApp.Categories.ToListAsync();
            return Ok(categories);

        }
    }
}
