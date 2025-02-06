using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class QuestReward
{
    public int Id { get; set; }

    public int QuestId { get; set; }

    public string Group { get; set; } = null!;

    public string Item { get; set; } = null!;

    public int Stack { get; set; }

    public int Percentage { get; set; }
}
