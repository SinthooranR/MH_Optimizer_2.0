using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class Skill
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? IconColor { get; set; }

    public double? Secret { get; set; }

    public string? Unlocks { get; set; }

    public string Description { get; set; } = null!;
}
