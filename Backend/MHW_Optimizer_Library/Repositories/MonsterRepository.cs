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
    public class MonsterRepository : IMonsterRepository
    {
        private readonly MhwOptimizerContext _context;

        private readonly IConfiguration _configuration;
        public MonsterRepository(MhwOptimizerContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<ICollection<Monster>> GetMonsterList()
        {
            return await _context.Monsters.FromSqlRaw("EXECUTE dbo.GetAllMonsters").ToListAsync();
        }
        public async Task<MonsterDetails> GetMonsterDetails(string monsterName)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                var multi = await connection.QueryMultipleAsync("GetMonsterDetailsByName",
                    new { MonsterName = monsterName },
                    commandType: CommandType.StoredProcedure);

                var monster = multi.Read<Monster>().FirstOrDefault();
                var ailments = multi.Read<MonsterAilment>().ToList();
                var breaks = multi.Read<MonsterBreak>().ToList();
                var hitzones = multi.Read<MonsterHitzone>().ToList();
                var rewards = multi.Read<MonsterReward>().ToList();
                var weaknesses = multi.Read<MonsterWeakness>().ToList();
                var habitats = multi.Read<MonsterHabitat>().ToList();

                MonsterDetails monsterDetails = new MonsterDetails()
                {
                    Monster = monster,
                    Monster_Ailments = ailments,
                    Monster_Breaks = breaks,
                    Monster_Hitzones = hitzones,
                    Monster_Habitats = habitats,
                    Monster_Rewards = rewards,
                    Monster_Weaknesses = weaknesses,
                };

                return monsterDetails;

            }
        }

    }
}
