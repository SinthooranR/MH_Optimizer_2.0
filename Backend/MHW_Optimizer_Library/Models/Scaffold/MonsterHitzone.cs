using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class MonsterHitzone
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Hitzone { get; set; } = null!;

    public int Cut { get; set; }

    public int Impact { get; set; }

    public int Shot { get; set; }

    public int Fire { get; set; }

    public int Water { get; set; }

    public int Thunder { get; set; }

    public int Ice { get; set; }

    public int Dragon { get; set; }

    public int Ko { get; set; }
}
