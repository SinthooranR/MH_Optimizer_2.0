using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class ItemCombination
{
    public int Id { get; set; }

    public int ItemCombinationId { get; set; }

    public string Result { get; set; } = null!;

    public string First { get; set; } = null!;

    public string? Second { get; set; }

    public int Quantity { get; set; }
}
