using MHW_Optimizer_Library.Models.Scaffold;

namespace MHW_Optimizer_Library.Models.Dto
{
    public class QuestDetails
    {
        public Quest Quest { get; set; }
        public ICollection<QuestMonster> Quest_Monsters { get; set; }
        public ICollection<QuestReward> Quest_Rewards { get; set; }
    }
}
