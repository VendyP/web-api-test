using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PalindromeController : ControllerBase
    {
        [HttpGet(template: "sentence")]
        public string Get([FromQuery] string input)
        {
            var results = PalindromHelper.Get(input);
            if (results.Count > 0)
                return string.Join(" ", results);
            else
                return "Not valid palindrom sentence";
        }
    }
}