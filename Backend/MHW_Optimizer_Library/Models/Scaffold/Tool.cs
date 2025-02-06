using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class Tool
{
    public int Id { get; set; }

    public int ToolId { get; set; }

    public string Name { get; set; } = null!;

    public string ToolType { get; set; } = null!;

    public int Duration { get; set; }

    public double? DurationUpgraded { get; set; }

    public int Recharge { get; set; }

    public int Slot1 { get; set; }

    public int Slot2 { get; set; }

    public int Slot3 { get; set; }

    public string Description { get; set; } = null!;
}
