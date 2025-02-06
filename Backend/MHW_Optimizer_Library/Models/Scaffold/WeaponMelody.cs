using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class WeaponMelody
{
    public int Id { get; set; }

    public int WeaponMelodyId { get; set; }

    public string Name { get; set; } = null!;

    public double? BaseDuration { get; set; }

    public double? BaseExtension { get; set; }

    public double? M1Duration { get; set; }

    public double? M1Extension { get; set; }

    public double? M2Duration { get; set; }

    public double? M2Extension { get; set; }
}
