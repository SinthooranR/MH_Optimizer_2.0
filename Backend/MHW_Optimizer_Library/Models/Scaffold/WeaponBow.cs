using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class WeaponBow
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string WeaponType { get; set; } = null!;

    public bool Close { get; set; }

    public bool Power { get; set; }

    public bool Paralysis { get; set; }

    public bool Poison { get; set; }

    public bool Sleep { get; set; }

    public bool Blast { get; set; }
}
