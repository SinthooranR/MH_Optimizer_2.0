using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class Quest
{
    public int Id { get; set; }

    public int QuestId { get; set; }

    public string Name { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Rank { get; set; } = null!;

    public int Stars { get; set; }

    public string QuestType { get; set; } = null!;

    public string Location { get; set; } = null!;

    public int Zenny { get; set; }

    public string Objective { get; set; } = null!;

    public string Description { get; set; } = null!;
}
