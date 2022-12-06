using System.ComponentModel.DataAnnotations;

namespace DataBase.Entities;

public record Group
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Name { get; set; }

    [Required]
    public string Title { get; set; }

    //Navigation Properties
    //Relationships

    public virtual ICollection<Product> Products { get; set; }
}
