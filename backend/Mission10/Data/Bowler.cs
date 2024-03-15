using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Mission10.Data;

namespace Mission10.data
{
    public class Bowler
    {
        [Key]
        public int bowlerID {  get; set; }
        public string bowlerLastName { get; set; }
        public string bowlerFirstName { get; set; }
        public string? bowlerMiddleInit { get; set; }
        public string bowlerAddress { get; set; }
        public string bowlerCity { get; set; }
        public string bowlerState { get; set; }
        public string bowlerZip { get; set; }
        public string bowlerPhoneNumber { get; set; }

        [ForeignKey("TeamID")]
        public int teamID { get; set; }
        public Team Team { get; set; }
      


    }
}
