using Microsoft.AspNetCore.Mvc;

namespace three_tier_architecture.Controllers.Base
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class ApiControllerBase : ControllerBase
    {
    }
}
