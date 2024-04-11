namespace VeterinaryShelter.Models;

public class Visit
{
    public DateTime DateOfVisit { set; get; }
    public Animal Animal { set; get; }
    public string DescriptionOfTheVisit { set; get; }
    public double PriceOfTheVisit { set; get; }

}