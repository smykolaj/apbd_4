using Microsoft.AspNetCore.Mvc;

namespace VeterinaryShelter.Controllers;


[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok();
    }
    


}