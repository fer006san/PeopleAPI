using System.ComponentModel.DataAnnotations;

namespace PeopleAPI.Models;

public class Car
{
    [Key]
    public int Id { get; set; }
    public string Brand { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int Year { get; set; }
}