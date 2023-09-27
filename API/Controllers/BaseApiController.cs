
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    
[ApiController]
[Route("api/[controller]")]//step1. When an Http request comes in, it's going to be
//routed to this controller.

//step2. The framework's going to see our user's controller and see the constructor
    public class BaseApiController : ControllerBase
    {

    }
}