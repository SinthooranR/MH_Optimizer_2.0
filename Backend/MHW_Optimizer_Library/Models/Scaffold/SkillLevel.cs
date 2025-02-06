using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class SkillLevel
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Level { get; set; }

    public string Description { get; set; } = null!;
}
