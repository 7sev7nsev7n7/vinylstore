using System.ComponentModel.DataAnnotations;

namespace RecordStoreWebApi.Entities
{
  public class Vinyl
  {
    public int ID { get; set; }
    [Required]
    public required string Name { get; set; }
    public string Artist { get; set; }
    public int Year { get; set; }
  }
}
