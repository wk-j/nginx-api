using Microsoft.AspNetCore.Mvc;

namespace MyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class BeflexController
    {
        [HttpGet]
        public string Upload()
        {
            return "Ok";
        }
    }
}