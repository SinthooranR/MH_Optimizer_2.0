using Dapper;
using MHW_Optimizer_Library.DataContexts;
using MHW_Optimizer_Library.Models.Dto;
using MHW_Optimizer_Library.Models.Scaffold;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;

namespace MHW_Optimizer_Library.Repositories
{
    public class QuestRepository : IQuestRepository
    {
        private readonly MhwOptimizerContext _context;
        private readonly IConfiguration _configuration;
        public QuestRepository(MhwOptimizerContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task<ICollection<Quest>> GetQuestList()
        {
            return await _context.Quests.FromSqlRaw("EXEC GetAllQuests").ToListAsync();
        }

        public async Task<QuestDetails> GetQuestDetails(int questId)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                var multi = await connection.QueryMultipleAsync("GetQuestInfoById",
                    new { QuestId = questId },
                    commandType: CommandType.StoredProcedure);

                var quest = multi.Read<Quest>().FirstOrDefault();
                var monsters = multi.Read<QuestMonster>().ToList();
                var rewards = multi.Read<QuestReward>().ToList();

                QuestDetails questDetails = new QuestDetails()
                {
                    Quest = quest,
                    Quest_Monsters = monsters,
                    Quest_Rewards = rewards
                };

                return questDetails;
            }

        }
    }
}
