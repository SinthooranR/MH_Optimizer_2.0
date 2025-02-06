using MHW_Optimizer_Library.Models.Dto;
using MHW_Optimizer_Library.Models.Scaffold;
using MHW_Optimizer_Library.Repositories;

namespace MHW_Optimizer_API.Services
{
    public class MonsterService
    {
        private readonly IMonsterRepository _monsterRepository;
        public MonsterService(IMonsterRepository monsterRepository)
        {
            _monsterRepository = monsterRepository;
        }

        public async Task<ICollection<Monster>> GetAllMonsters()
        {
            return await _monsterRepository.GetMonsterList();
        }

        public async Task<MonsterDetails> GetMonsterDetails(string monsterName)
        {
            var monster = await _monsterRepository.GetMonsterDetails(monsterName);
            return monster;

        }
    }
}
