using Microsoft.AspNetCore.Mvc;

namespace CleanApp.Host.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class ApiControllerBase : ControllerBase
{
}
