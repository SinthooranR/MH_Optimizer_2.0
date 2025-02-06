using MHW_Optimizer_Library.Models.Scaffold;

namespace MHW_Optimizer_Library.Models.Dto
{
    public class MonsterDetails
    {
        public Monster Monster { get; set; }
        public ICollection<MonsterAilment> Monster_Ailments { get; set; }

        public ICollection<MonsterWeakness> Monster_Weaknesses { get; set; }

        public ICollection<MonsterBreak> Monster_Breaks { get; set; }

        public ICollection<MonsterHitzone> Monster_Hitzones { get; set; }

        public ICollection<MonsterReward> Monster_Rewards { get; set; }

        public ICollection<MonsterHabitat> Monster_Habitats { get; set; }

    }
}
