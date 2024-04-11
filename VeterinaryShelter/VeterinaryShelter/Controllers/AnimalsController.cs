using Microsoft.AspNetCore.Mvc;
using VeterinaryShelter.Database;
using VeterinaryShelter.Models;

namespace VeterinaryShelter.Controllers;


[ApiController]
[Route("[controller]")]
public class AnimalsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAnimals()
    {
        var animals = StaticData.Animals;
        return Ok(animals);
    }
    
    [HttpGet("{id:int}")]
    public IActionResult GetAnimalById(int id)
    {
        foreach (var animal in StaticData.Animals)
        {
            if (animal.Id.Equals(id))
            {
                return Ok(animal);
            }
        }
        return NotFound();
    }
    
    [HttpPost]
    public IActionResult CreateAnimal()
    {
        StaticData.Animals.Add(new Animal({Id = StaticData.Animals.Count+1, FirstName = }));
        var animals = StaticData.Animals;
        
        
        return Ok(animals);
    }
    [HttpPut]
    public IActionResult EditAnimal()
    {
        var animals = StaticData.Animals;
        
        
        return Ok(animals);
    }
    
    [HttpDelete]
    public IActionResult DeleteAnimal()
    {
        var animals = StaticData.Animals;
        
        
        return Ok(animals);
    }
    


}