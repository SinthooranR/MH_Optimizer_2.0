using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class Weapon
{
    public int Id { get; set; }

    public int WeaponId { get; set; }

    public string Name { get; set; } = null!;

    public string WeaponType { get; set; } = null!;

    public string? Previous { get; set; }

    public string? Category { get; set; }

    public int Rarity { get; set; }

    public int Attack { get; set; }

    public int Affinity { get; set; }

    public double? Defense { get; set; }

    public bool ElementHidden { get; set; }

    public string? Element1 { get; set; }

    public double? Element1Attack { get; set; }

    public string? Element2 { get; set; }

    public double? Element2Attack { get; set; }

    public string? Elderseal { get; set; }

    public int Slot1 { get; set; }

    public int Slot2 { get; set; }

    public int Slot3 { get; set; }

    public string? KinsectBonus { get; set; }

    public string? Phial { get; set; }

    public double? PhialPower { get; set; }

    public string? Shelling { get; set; }

    public double? ShellingLevel { get; set; }

    public string? Notes { get; set; }

    public string? AmmoConfig { get; set; }

    public string? Skill { get; set; }
}
