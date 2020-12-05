using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Betting.Data.Models
{
    public class Color
    {
        public Color()
        {
            this.PrimaryKitTeam = new HashSet<Team>();
            this.SecondaryKitTeam = new HashSet<Team>();
        }

        [Key]
        public int ColorId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        public virtual ICollection<Team> PrimaryKitTeam { get; set; }
        public virtual ICollection<Team> SecondaryKitTeam { get; set; }
    }
}