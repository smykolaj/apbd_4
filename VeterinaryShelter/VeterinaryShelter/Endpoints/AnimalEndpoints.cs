using VeterinaryShelter.Database;
using VeterinaryShelter.Models;

namespace VeterinaryShelter.Endpoints;

public static class AnimalEndpoints
{
    public static void MapAnimalsEndpoints(this WebApplication app)
    {
        //GET
        app.MapGet("/animals/{id}", (int id) =>
            {
                foreach (var animal in StaticData.Animals)
                {
                    if (animal.Id == id)
                    {
                        return Results.Ok(animal);
                    }
                }
                return Results.NotFound();
            }
        );
        
        //GET
        app.MapGet("/animals/", () => Results.Ok(StaticData.Animals));
        
        //POST
        app.MapPost("/animals", (Animal animal) =>
        {
            StaticData.Animals.Add(animal);
            return Results.Created("", animal);
        });
        //PUT
        app.MapPut("/animals", (Animal editedAnimal) =>
        {
            Animal animalToChange = null;
            foreach (var animal in StaticData.Animals)
            {
                if (animal.Id == editedAnimal.Id)
                {
                    animalToChange = animal;
                    break;
                }
            }
            if (animalToChange == null)
            {
                return Results.BadRequest();
            }

            animalToChange.Category = editedAnimal.Category;
            animalToChange.Weight = editedAnimal.Weight;
            animalToChange.FirstName = editedAnimal.FirstName;
            animalToChange.FurColor = editedAnimal.FurColor;
            return Results.Created("", animalToChange);

        });
        //Delete
        app.MapDelete("/animals/{id}", (int id) =>
        {
            Animal animalToChange = null;
            foreach (var animal in StaticData.Animals)
            {
                if (animal.Id == id)
                {
                    animalToChange = animal;
                    break;
                }
            }
            if (animalToChange == null)
            {
                return Results.BadRequest();
            }

            StaticData.Animals.Remove(animalToChange);
            return Results.Ok();
        });
        
        
        
        
    }
}