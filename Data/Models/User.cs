using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Betting.Data.Models
{
    public class User
    {
        public User()
        {
            this.BetsSubmissions = new HashSet<Bet>();
        }

        [Key]
        public int UserId { get; set; }

        public decimal Balance { get; set; }

        [MaxLength(64)]
        public string Email { get; set; }

        [MaxLength(128)]
        public string Name { get; set; }

        [Column(TypeName = "varchar(max)")]
        public string Password { get; set; }

        [MaxLength(128)]
        public string Username { get; set; }

        public virtual ICollection<Bet> BetsSubmissions { get; set; }
    }
}