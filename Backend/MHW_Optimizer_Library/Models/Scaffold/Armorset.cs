using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class Armorset
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Rank { get; set; } = null!;

    public string? Monster { get; set; }

    public string? Head { get; set; }

    public string? Chest { get; set; }

    public string? Arms { get; set; }

    public string? Waist { get; set; }

    public string? Legs { get; set; }

    public string? Bonus { get; set; }
}
