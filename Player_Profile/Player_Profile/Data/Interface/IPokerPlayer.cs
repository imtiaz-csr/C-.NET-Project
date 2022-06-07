using Player_Profile.Data.Enum;

namespace Player_Profile.Data.Interface
{
    public interface IPokerPlayer
    {
        public int Rank { get; set; }
        public PokerTeam Team { get; set; }
        public string AchievementInPoker { get; set; }
    }
}
