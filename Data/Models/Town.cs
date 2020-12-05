using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Town
    {
        public Town()
        {
            this.HomeTown = new HashSet<Team>();
        }

        [Key]
        public int TownId { get; set; }

        [MaxLength(64)]
        public string Name { get; set; }

        [ForeignKey("Countries")]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }

        public virtual ICollection<Team> HomeTown { get; set; }
    }
}