using MHW_Optimizer_Library.Models.Dto;
using MHW_Optimizer_Library.Models.Scaffold;
using MHW_Optimizer_Library.Repositories;

namespace MHW_Optimizer_API.Services
{
    public class QuestService
    {
        private readonly IQuestRepository _questRepository;
        public QuestService(IQuestRepository questRepository)
        {
            _questRepository = questRepository;
        }

        public async Task<ICollection<Quest>> GetAllQuests()
        {
            return await _questRepository.GetQuestList();
        }

        public async Task<QuestDetails> GetQuestDetails(int questId)
        {
            return await _questRepository.GetQuestDetails(questId);
        }
    }
}
