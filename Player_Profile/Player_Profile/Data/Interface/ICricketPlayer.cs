using Player_Profile.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace Player_Profile.Data.Interface
{
    public interface ICricketPlayer
    {
        public CricketTeam Team { get; set; }
        public int TotalRun { get; set; }
        public int? Total6 { get; set; }
        public int TotalWickets { get; set; }

        [StringLength(500, ErrorMessage = "Achievement should not exceed 500 characters")]
        public string? AchievementInCricket { get; set; }
    }
}
