using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class ArmorSkill
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Skill1Name { get; set; }

    public double? Skill1Level { get; set; }

    public string? Skill2Name { get; set; }

    public double? Skill2Level { get; set; }
}
