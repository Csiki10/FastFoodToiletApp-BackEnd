using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ToiletApp.Models
{
    public class AppFileData
    {
        public int Id { get; set; }
        public byte[] Content { get; set; }
        public string ContentType { get; set; }
        public string FileName { get; set; }

        [Required]
        [NotMapped]
        [JsonIgnore]
        public Toilet Toilet { get; set; }
    }
}
