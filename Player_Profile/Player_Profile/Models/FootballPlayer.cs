using Player_Profile.Data.Enum;
using Player_Profile.Data.Interface;
using Player_Profile.Enum;

namespace Player_Profile.Models
{
    public class FootballPlayer : Player, IFootballPlayer
    {
        public FootballTeam Team { get ; set ; }
        public int GoalScore { get; set; }
        public string AchievementInFootball { get; set; }
    }
}
