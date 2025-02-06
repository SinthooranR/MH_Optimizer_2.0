using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class MonsterHabitat
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Map { get; set; } = null!;

    public double? StartArea { get; set; }

    public string? MoveArea { get; set; }

    public string? RestArea { get; set; }
}
