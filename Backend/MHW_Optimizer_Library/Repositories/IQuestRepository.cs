using MHW_Optimizer_Library.Models.Dto;
using MHW_Optimizer_Library.Models.Scaffold;

namespace MHW_Optimizer_Library.Repositories
{
    public interface IQuestRepository
    {
        Task<ICollection<Quest>> GetQuestList();

        Task<QuestDetails> GetQuestDetails(int questId);
    }
}
