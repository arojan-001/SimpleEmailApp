using Microsoft.AspNetCore.Mvc;

namespace SimpleEmailApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _service;

        public EmailController(IEmailService service)
        {
            _service = service;
        }
        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            _service.SendEmail(request);

            return Ok();
        }
        
    }
}
