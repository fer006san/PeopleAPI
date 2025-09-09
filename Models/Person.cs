using System.ComponentModel.DataAnnotations;

namespace PeopleAPI.Models;

public class Person
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public int Age { get; set; }
}