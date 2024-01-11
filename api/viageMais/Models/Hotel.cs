using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace viageMais.Models
{
  [Table("hotel")]
  public class Hotel
  {
    // [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    [Required]
    [Column("name")]
    public string Name { get; set; }
    [Required]
    [Column("mainName")]
    public string MainName { get; set; }
    [Required]
    [Column("imgUrl")]
    public string ImgUrl { get; set; }
    [Required]
    [Column("stars")]
    public int Stars { get; set; }
    [Required]
    [Column("assessments")]
    public int Assessments { get; set; }
    [Required]
    [Column("price")]
    public int Price { get; set; }
  }
}