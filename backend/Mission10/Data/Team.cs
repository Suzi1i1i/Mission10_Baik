using System.ComponentModel.DataAnnotations;

namespace Mission10.Data
{
    public class Team
    {
        [Key]
        public int teamID { get; set; }
        public string teamName { get; set; }
    }
}
