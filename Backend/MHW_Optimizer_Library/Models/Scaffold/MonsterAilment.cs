using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class MonsterAilment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Roar { get; set; }

    public string? Wind { get; set; }

    public string? Tremor { get; set; }

    public string? DefenseDown { get; set; }

    public string? Fireblight { get; set; }

    public string? Waterblight { get; set; }

    public string? Thunderblight { get; set; }

    public string? Iceblight { get; set; }

    public string? Dragonblight { get; set; }

    public string? Blastblight { get; set; }

    public string? Regional { get; set; }

    public string? Poison { get; set; }

    public string? Sleep { get; set; }

    public string? Paralysis { get; set; }

    public string? Bleed { get; set; }

    public string? Stun { get; set; }

    public string? Mud { get; set; }

    public string? Effluvia { get; set; }
}
