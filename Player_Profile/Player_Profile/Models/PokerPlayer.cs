using Player_Profile.Data.Enum;
using Player_Profile.Data.Interface;
using Player_Profile.Enum;

namespace Player_Profile.Models
{
    public class PokerPlayer : Player, IPokerPlayer
    {
        public int Rank { get ; set ; }
        public PokerTeam Team { get; set; }
        public string AchievementInPoker { get; set; }
    }
}
