using MHW_Optimizer_Library.Models.Dto;
using MHW_Optimizer_Library.Models.Scaffold;

namespace MHW_Optimizer_Library.Repositories
{
    public interface IMonsterRepository
    {
        Task<ICollection<Monster>> GetMonsterList();
        Task<MonsterDetails> GetMonsterDetails(string monsterName);
    }
}