using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class Decoration
{
    public int Id { get; set; }

    public int DecorationId { get; set; }

    public string Name { get; set; } = null!;

    public int Slot { get; set; }

    public int Rarity { get; set; }

    public string Skill1Name { get; set; } = null!;

    public int Skill1Level { get; set; }

    public string? Skill2Name { get; set; }

    public double? Skill2Level { get; set; }

    public string? IconColor { get; set; }
}
