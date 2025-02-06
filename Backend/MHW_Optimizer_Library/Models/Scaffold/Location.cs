using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class Location
{
    public int Id { get; set; }

    public int LocationId { get; set; }

    public string Name { get; set; } = null!;
}
