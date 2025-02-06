using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class QuestMonster
{
    public int Id { get; set; }

    public int QuestId { get; set; }

    public string Monster { get; set; } = null!;

    public int Quantity { get; set; }

    public bool IsObjective { get; set; }
}
