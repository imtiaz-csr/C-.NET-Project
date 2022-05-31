using Player_Profile.Enum;

namespace Player_Profile.Models
{
    public class PokerPlayer : Player
    {
        public override int PlayerId { get; set; }
        public override string PhotoUrlPath { get; set; }
        public override string Name { get; set; }
        public override Gender Gender { get; set; }
        public override int Age { get; set; }
        public override Country Country { get; set; }
        public override string Achievement { get; set; }
        public override bool? IsRetired { get; set; }
    }
}
