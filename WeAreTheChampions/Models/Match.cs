using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeAreTheChampions.Models
{
    [Table("Matches")]
    public class Match
    {
        public int Id { get; set; }

        public DateTime? MatchTime { get; set; }

        // :::::::::::::::::NOT::::::::::::::::
        //Error : İntroducing FOREIGN KEY constraint 'FK_dbo.Matches_dbo.Teams_HomeTeamId' on table 'Matches'
        //may cause cycles or multiple cascade paths. Specify ON DELETE NO ACTION
        //or ON UPDATE NO ACTION, or modify other FOREIGN KEY constraints.
        //https://stackoverflow.com/questions/5559043/entity-framework-code-first-two-foreign-keys-from-same-table

                                                 //according these error and given link I came to the following conclusion
        /*[ForeignKey("HomeTeam")]*/             // if we will add these foreign keys , and if we decided to delete some matches  
        public int HomeTeamId { get; set; }      // and beacause cascade deletion was true our integreted with foreignkey teams will disappear
                                                 //cause of this this situation we have to change cascade deleting and we have to use O
        //[ForeignKey("GuestTeam")]              //OnModelCreating , gives foreignKeys there and close cascade deleting inside of same method. 
        public int GuestTeamId { get; set; }

        public int? HomePoints { get; set; }

        public int? GuestPoints { get; set; }

        public MatchResult? Result { get; set; }

        public virtual  Team HomeTeam { get; set; }
        public virtual  Team GuestTeam { get; set; }

    }
}
