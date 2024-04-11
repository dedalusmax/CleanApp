using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanApp.Host.Controllers;

//[Authorize]
[Route("api/[controller]")]
[ApiController]
public class ExamController : ControllerBase
{
    [HttpGet]
    public async Task GetExamsAsync()
    {
        await Task.CompletedTask;
    }
}
