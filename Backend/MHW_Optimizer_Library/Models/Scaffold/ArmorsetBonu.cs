using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class ArmorsetBonu
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Skill1Name { get; set; } = null!;

    public int Skill1Required { get; set; }

    public string? Skill2Name { get; set; }

    public double? Skill2Required { get; set; }
}
