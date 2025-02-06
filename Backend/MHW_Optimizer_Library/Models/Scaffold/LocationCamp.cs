using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class LocationCamp
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string CampName { get; set; } = null!;

    public int Area { get; set; }
}
