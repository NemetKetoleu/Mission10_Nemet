using System.ComponentModel.DataAnnotations;

namespace Mission10_Nemet.Data
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; }

        [Required]
        [StringLength(15, MinimumLength = 2)] 
        public string TeamName { get; set; }
    }
}
