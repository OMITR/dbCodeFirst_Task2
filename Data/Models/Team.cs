using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Team
    {
        public Team()
        {
            this.HomeGame = new HashSet<Game>();
            this.AwayGame = new HashSet<Game>();
            this.PlayerInfo = new HashSet<Player>();
        }

        [Key]
        public int TeamId { get; set; }

        public decimal Budget { get; set; }

        public string Initials { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string LogoUrl { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }

        [ForeignKey("Colors")]
        public int PrimaryKitColorId { get; set; }

        [ForeignKey("Colors")]
        public int SecondaryKitColorId { get; set; }

        [ForeignKey("Towns")]
        public int TownId { get; set; }
        public virtual Town Town { get; set; }
        public virtual Color PrimaryKitColor { get; set; }
        public virtual Color SecondaryKitColor { get; set; }
        public virtual ICollection<Game> HomeGame { get; set; }
        public virtual ICollection<Game> AwayGame { get; set; }
        public virtual ICollection<Player> PlayerInfo { get; set; }
    }
}