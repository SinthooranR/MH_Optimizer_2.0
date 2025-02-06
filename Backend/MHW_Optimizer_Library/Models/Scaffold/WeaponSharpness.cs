using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class WeaponSharpness
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string WeaponType { get; set; } = null!;

    public bool Maxed { get; set; }

    public int Red { get; set; }

    public int Orange { get; set; }

    public int Yellow { get; set; }

    public int Green { get; set; }

    public int Blue { get; set; }

    public int White { get; set; }

    public int Purple { get; set; }
}
