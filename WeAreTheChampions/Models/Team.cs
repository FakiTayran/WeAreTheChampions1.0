using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{   
    [Table("Teams")]
    public class Team
    {
        public Team()
        {
            Colors = new HashSet<Color>();
            Players = new HashSet<Player>();
        }
        public int Id { get; set; }

        [Required,MaxLength(100)]
        public string TeamName { get; set; }

        public virtual ICollection<Color> Colors { get; set; }
        //team has players.
        public virtual ICollection<Player>Players { get; set; }

        //A team has both too many matches, inside or outside , cause of this situation , i added these ICollection Navigators 
        public virtual ICollection<Match>HomeMatches { get; set; }
        public virtual ICollection<Match>AwayMatches { get; set; }

        public override string ToString()
        {
            return TeamName;
        }

    }
}
