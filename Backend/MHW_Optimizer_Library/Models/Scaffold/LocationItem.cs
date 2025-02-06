using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class LocationItem
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Area { get; set; }

    public string? Rank { get; set; }

    public string ItemLang { get; set; } = null!;

    public string Item { get; set; } = null!;

    public int Stack { get; set; }

    public int Percentage { get; set; }

    public double? Nodes { get; set; }
}
