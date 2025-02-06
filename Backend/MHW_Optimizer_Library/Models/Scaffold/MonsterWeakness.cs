using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class MonsterWeakness
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Form { get; set; } = null!;

    public string? AltDescription { get; set; }

    public int Fire { get; set; }

    public int Water { get; set; }

    public int Thunder { get; set; }

    public int Ice { get; set; }

    public int Dragon { get; set; }

    public double? Poison { get; set; }

    public double? Sleep { get; set; }

    public double? Paralysis { get; set; }

    public double? Blast { get; set; }

    public double? Stun { get; set; }
}
