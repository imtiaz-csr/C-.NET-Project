using Player_Profile.Data.Enum;
using Player_Profile.Data.Interface;
using Player_Profile.Enum;

namespace Player_Profile.Models
{
    public class TennisPlayer : Player, ITennisPlayer
    {
        public double Height { get ; set ; }
        public string AchievementInTennis { get; set; }
        public TennisTeam Team { get; set; }
    }
}
