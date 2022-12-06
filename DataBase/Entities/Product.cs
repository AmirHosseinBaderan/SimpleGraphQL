using System.ComponentModel.DataAnnotations;

namespace DataBase.Entities;

public record Product
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public string Description { get; set; }

    [Required]
    public float Amount { get; set; }

    [Required]
    public Guid GroupId { get; set; }

    //Navigation Properties
    //Relationships

    public virtual Group Group { get; set; }
}
