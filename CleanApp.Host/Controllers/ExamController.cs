using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanApp.Host.Controllers;

//[Authorize]
public class ExamController : ApiControllerBase
{
    [HttpGet]
    public async Task GetExamsAsync()
    {
        await Task.CompletedTask;
    }
}
