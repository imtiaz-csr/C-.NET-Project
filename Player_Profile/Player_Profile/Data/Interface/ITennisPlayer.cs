using Player_Profile.Data.Enum;

namespace Player_Profile.Data.Interface
{
    public interface ITennisPlayer
    {
        public double Height { get; set; }
        public string AchievementInTennis { get; set; }
        public TennisTeam Team { get; set; }
    }
}
