using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission10_Nemet.Data
{
    public class Bowler
    {
            // Primary Key
            [Key]
            public int BowlerId { get; set; }

            // Bowler Name (First, Middle, Last)
            public string? BowlerFirstName { get; set; }

            public string? BowlerMiddleInit { get; set; }
            public string? BowlerLastName { get; set; }

            // Address, City, State, Zip
            public string? BowlerAddress { get; set; }
            public string? BowlerCity { get; set; }
            public string? BowlerState { get; set; }
            public string? BowlerZip { get; set; }

            // Phone Number
            public string? BowlerPhoneNumber { get; set; }

            [ForeignKey("TeamID")]
            public int? TeamID { get; set; }
            [Range(2, 15)]
            public Team? Team { get; set; }
    }
}

