using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class Monster
{
    public int Id { get; set; }

    public int MonsterId { get; set; }

    public string Name { get; set; } = null!;

    public string? Ecology { get; set; }

    public string Size { get; set; } = null!;

    public string? PitfallTrap { get; set; }

    public string? ShockTrap { get; set; }

    public string? VineTrap { get; set; }

    public string Description { get; set; } = null!;
}
