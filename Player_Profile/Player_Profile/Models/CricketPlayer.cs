using Player_Profile.Data.Enum;
using Player_Profile.Data.Interface;
using Player_Profile.Enum;

namespace Player_Profile.Models
{
    public class CricketPlayer : Player, ICricketPlayer
    {
        public CricketTeam Team { get; set; }
        public int TotalRun { get ; set ; }
        public int? Total6 { get; set; }
        public int TotalWickets { get; set; }
        public string AchievementInCricket { get; set; }
        
    }

}
