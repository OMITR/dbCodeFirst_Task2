using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Player
    {
        public Player()
        {
            this.MatchInfo = new HashSet<PlayerStatistic>();
        }

        [Key]
        public int PlayerId { get; set; }

        public string IsInjured { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        public int SquadNumber { get; set; }

        [ForeignKey("Positions")]
        public int PositionId { get; set; }
        public virtual Position Position { get; set; }

        [ForeignKey("Teams")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }

        public virtual ICollection<PlayerStatistic> MatchInfo { get; set; }
    }


}