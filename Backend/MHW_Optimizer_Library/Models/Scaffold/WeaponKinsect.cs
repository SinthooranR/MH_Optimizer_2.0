using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class WeaponKinsect
{
    public int Id { get; set; }

    public int WeaponKinsectId { get; set; }

    public string Name { get; set; } = null!;

    public string? Previous { get; set; }

    public int Rarity { get; set; }

    public string AttackType { get; set; } = null!;

    public string DustEffect { get; set; } = null!;

    public int Power { get; set; }

    public int Speed { get; set; }

    public int Heal { get; set; }
}
