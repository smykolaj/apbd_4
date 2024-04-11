using System.Collections;
using VeterinaryShelter.Database;
using VeterinaryShelter.Models;

namespace VeterinaryShelter.Endpoints;

public static class VisitsEndpoints
{
    public static void MapVisitsEndpoints(this WebApplication app)
    {
        
         //GET
        app.MapGet("/visits/{id}", (int id) =>
            {
                var listOfAnimalVisits = new ArrayList();
                foreach (var visit in StaticData.Visits)
                {
                    if (visit.AnimalId == id)
                    {
                        listOfAnimalVisits.Add(visit);
                    }
                }

                if (listOfAnimalVisits.Count == 0)
                {
                    return Results.NotFound();
                }

                return Results.Ok(listOfAnimalVisits);

            }
        );
        
        //GET
        app.MapGet("/visits/", () => Results.Ok(StaticData.Visits));
        
        //POST
        app.MapPost("/visits", (Visit visit) =>
        {
            StaticData.Visits.Add(visit);
            return Results.Created("", visit);
        });
        
        
        
        
        
        
        
    }
}