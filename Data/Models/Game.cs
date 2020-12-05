using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Betting.Data.Models
{
    public class Game
    {
        public Game()
        {
            this.MatchInfo = new HashSet<PlayerStatistic>();
            this.BetsSubmissions = new HashSet<Bet>();
        }

        [Key]
        public int GameId { get; set; }

        public decimal AwayTeamBetRate { get; set; }

        public int AwayTeamGoals { get; set; }

        public decimal DrawBetRate { get; set; }

        public decimal HomeTeamBetRate { get; set; }

        public int HomeTeamGoals { get; set; }

        public PredictionType PredictionType { get; set; }
        public int Result { get; set; }

        public DateTime DateTime { get; set; }

        [ForeignKey("Teams")]
        public int AwayTeamId { get; set; }

        [ForeignKey("Teams")]
        public int HomeTeamId { get; set; }

        public virtual Team AwayTeam { get; set; }
        public virtual Team HomeTeam { get; set; }
        public virtual ICollection<PlayerStatistic> MatchInfo { get; set; }
        public virtual ICollection<Bet> BetsSubmissions { get; set; }
    }
}