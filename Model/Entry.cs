using System.ComponentModel.DataAnnotations;

namespace M223PunchclockDotnet.Model
{
    public class Entry
    {
        public int Id { get; set; }
        
        [Required]
        public DateTime CheckIn { get; set; }
        
        [Required]
        public DateTime CheckOut { get; set; }
    }
}
