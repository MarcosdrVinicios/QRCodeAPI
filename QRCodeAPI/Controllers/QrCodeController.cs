using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRCodeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QrCodeController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetByUrl([FromQuery] string url)
        {
            if (string.IsNullOrEmpty(url))
            {
                url = "https://medium.com/@marcosvinicios_net";
            }
            var image = QrCodeGenerator.GenerateByteArray(url);
            return File(image, "image/jpeg");
        }
    }
}
