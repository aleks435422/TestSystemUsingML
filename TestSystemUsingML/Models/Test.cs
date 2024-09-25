using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using TestSystemUsingML.Models;

public class Test
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(200)]
    public string Title { get; set; }

    public string Description { get; set; }

    [ForeignKey("Creator")]
    public int CreatedBy { get; set; }
    public User Creator { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Question> Questions { get; set; }
}