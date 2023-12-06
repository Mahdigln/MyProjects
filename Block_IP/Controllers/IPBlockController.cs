using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Block_IP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IPBlockController : ControllerBase
    {
        [HttpGet("unblocked")]
        public string Unblocked()
        {
            return "Unblocked access";
        }
        [HttpGet("blocked")]
        public string Blocked()
        {
            return "Blocked access";
        }
    }
}
