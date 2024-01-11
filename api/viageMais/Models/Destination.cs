

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace viageMais.Models
{
  [Table("destination")]
  public class Destination
  {

    //[Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Required]
    [Column("city")]
    public string City { get; set; }
    [Required]
    [Column("mainName")]
    public string MainName { get; set; }
    [Required]
    [Column("country")]
    public string Country { get; set; }
    [Required]
    [Column("description")]
    public string Description { get; set; }
    [Required]
    [Column("imgUrl")]
    public string ImgUrl { get; set; }
  }
}