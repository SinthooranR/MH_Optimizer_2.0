using MHW_Optimizer_API.Services;
using MHW_Optimizer_Library.Models.Dto;
using Microsoft.AspNetCore.Mvc;

namespace MHW_Optimizer_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterController : ControllerBase
    {
        private readonly MonsterService _monsterService;
        public MonsterController(MonsterService monsterService)
        {
            _monsterService = monsterService;
        }

        [HttpGet]
        public async Task<IActionResult> getAllMonsters()
        {
            var monsters = await _monsterService.GetAllMonsters();

            if (monsters == null || monsters.Count == 0)
            {
                ModelState.AddModelError("", "No Monster Data Found");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(monsters);

        }

        [HttpGet("{monsterName}")]
        [ProducesDefaultResponseType(typeof(MonsterDetails))]
        public async Task<IActionResult> getLargeMonsterByName(string monsterName)
        {
            var monsterInfo = await _monsterService.GetMonsterDetails(monsterName);


            if (monsterInfo == null)
            {
                ModelState.AddModelError("", "No Monster Data Found");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(monsterInfo);
        }
    }
}
