using Player_Profile.Data.Enum;

namespace Player_Profile.Data.Interface
{
    public interface IFootballPlayer
    {
        public FootballTeam Team { get; set; }
        public int GoalScore { get; set; }
        public string AchievementInFootball { get; set; }
    }
}
