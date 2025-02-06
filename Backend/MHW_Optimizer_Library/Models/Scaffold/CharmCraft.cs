using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class CharmCraft
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Item1Name { get; set; } = null!;

    public int Item1Qty { get; set; }

    public string Item2Name { get; set; } = null!;

    public int Item2Qty { get; set; }

    public string Item3Name { get; set; } = null!;

    public int Item3Qty { get; set; }

    public string? Item4Name { get; set; }

    public double? Item4Qty { get; set; }
}
