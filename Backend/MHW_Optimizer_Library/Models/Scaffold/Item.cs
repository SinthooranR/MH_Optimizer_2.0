using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class Item
{
    public int Id { get; set; }

    public int ItemId { get; set; }

    public string Name { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string? Subcategory { get; set; }

    public double? Rarity { get; set; }

    public double? BuyPrice { get; set; }

    public double? SellPrice { get; set; }

    public double? CarryLimit { get; set; }

    public double? Points { get; set; }

    public string IconName { get; set; } = null!;

    public string IconColor { get; set; } = null!;

    public string? Description { get; set; }
}
