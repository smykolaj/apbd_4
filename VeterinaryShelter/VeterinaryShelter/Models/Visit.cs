namespace VeterinaryShelter.Models;

public class Visit
{
    public int Id { set; get; }
    public DateTime DateOfVisit { set; get; }
    public int AnimalId { set; get; }
    public string DescriptionOfTheVisit { set; get; }
    public double PriceOfTheVisit { set; get; }

}