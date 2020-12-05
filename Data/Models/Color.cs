using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Betting.Data.Models
{
    public class Color
    {
        public Color()
        {
            this.PrimaryKitColor = new HashSet<Team>();
            this.SecondaryKitColor = new HashSet<Team>();
        }

        [Key]
        public int ColorId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        public virtual ICollection<Team> PrimaryKitColor { get; set; }
        public virtual ICollection<Team> SecondaryKitColor { get; set; }
    }
}