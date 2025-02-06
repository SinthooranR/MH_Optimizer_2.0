using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class MonsterReward
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Rank { get; set; } = null!;

    public string Condition { get; set; } = null!;

    public string Item { get; set; } = null!;

    public int Stack { get; set; }

    public double? Percentage { get; set; }
}
