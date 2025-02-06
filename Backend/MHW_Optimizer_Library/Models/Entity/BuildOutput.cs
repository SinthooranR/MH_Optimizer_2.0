using MHW_Optimizer_Library.Models.Scaffold;
using System.ComponentModel.DataAnnotations.Schema;

namespace MHW_Optimizer_Library.Models.Entity
{
    public class BuildOutput
    {
        public int Id { get; set; }
        public int BuildProfileId { get; set; }

        [ForeignKey(nameof(BuildProfileId))]
        public BuildProfile Profile { get; set; }
        public ICollection<Skill> Skills { get; set; }
        public ICollection<WeaponSharpness> WeaponSharpness { get; set; }

        public ICollection<WeaponMelody>? WeaponMelodies { get; set; }

        public ICollection<WeaponMelodyNote> WeaponMelodyNotes { get; set; }

        public ICollection<Quest> QuestList { get; set; }

        public ICollection<Monster> MonsterList { get; set; }
    }
}
