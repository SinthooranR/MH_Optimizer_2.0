using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class MonsterBreak
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Part { get; set; } = null!;

    public double? PartJa { get; set; }

    public double? Flinch { get; set; }

    public double? Wound { get; set; }

    public double? Sever { get; set; }

    public string Extract { get; set; } = null!;
}
