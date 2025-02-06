using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class Armor
{
    public int Id { get; set; }

    public int ArmorId { get; set; }

    public string Name { get; set; } = null!;

    public int Rarity { get; set; }

    public string Type { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public int Slot1 { get; set; }

    public int Slot2 { get; set; }

    public int Slot3 { get; set; }

    public int DefenseBase { get; set; }

    public int DefenseMax { get; set; }

    public int DefenseAugmentMax { get; set; }

    public int DefenseFire { get; set; }

    public int DefenseWater { get; set; }

    public int DefenseThunder { get; set; }

    public int DefenseIce { get; set; }

    public int DefenseDragon { get; set; }
}
