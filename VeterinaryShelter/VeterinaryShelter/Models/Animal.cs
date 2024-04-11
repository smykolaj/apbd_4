using VeterinaryShelter.Enums;

namespace VeterinaryShelter.Models;

public class Animal(int id, string firstName, string category, double weight, string furColor)
{
    public int Id { get; set; } = id;
    public string FirstName { get; set; } = firstName;
    public string Category { get; set; } = category;
    public double Weight { get; set; } = weight;
    public string FurColor { get; set; } = furColor;
}

