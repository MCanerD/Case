using Bayi.Core.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bayi.API.Controllers
{
    public class CustomBaseController : ControllerBase
    {

        [NonAction] //endpoint olmadığı belirtildi.
        public IActionResult CreateActionResult<T>(CustomResponseDTO<T> response)
        {
            if(response.StatusCode == 204)
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };
            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
