using MHW_Optimizer_API.Services;
using Microsoft.AspNetCore.Mvc;

namespace MHW_Optimizer_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestController : ControllerBase
    {
        private readonly QuestService _questService;
        public QuestController(QuestService questService)
        {
            _questService = questService;
        }

        [HttpGet]
        public async Task<IActionResult> getAllQuests()
        {
            var quests = await _questService.GetAllQuests();

            if (quests == null)
            {
                ModelState.AddModelError("", "No Quests found");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            return Ok(quests);
        }

        [HttpGet("{questId}")]
        public async Task<IActionResult> getQuestDetailsById(int questId)
        {
            var questDetails = await _questService.GetQuestDetails(questId);
            if (questDetails == null)
            {
                ModelState.AddModelError("", "No Quest was found");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(questDetails);
        }
    }
}
