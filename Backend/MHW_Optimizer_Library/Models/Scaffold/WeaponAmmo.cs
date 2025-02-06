using System;
using System.Collections.Generic;

namespace MHW_Optimizer_Library.Models.Scaffold;

public partial class WeaponAmmo
{
    public int Id { get; set; }

    public string Key { get; set; } = null!;

    public int Deviation { get; set; }

    public string Special { get; set; } = null!;

    public int Normal1Clip { get; set; }

    public string? Normal1Rapid { get; set; }

    public int Normal1Recoil { get; set; }

    public string Normal1Reload { get; set; } = null!;

    public int Normal2Clip { get; set; }

    public string? Normal2Rapid { get; set; }

    public double? Normal2Recoil { get; set; }

    public string? Normal2Reload { get; set; }

    public int Normal3Clip { get; set; }

    public string? Normal3Rapid { get; set; }

    public double? Normal3Recoil { get; set; }

    public string? Normal3Reload { get; set; }

    public int Pierce1Clip { get; set; }

    public double? Pierce1Rapid { get; set; }

    public double? Pierce1Recoil { get; set; }

    public string? Pierce1Reload { get; set; }

    public int Pierce2Clip { get; set; }

    public string? Pierce2Rapid { get; set; }

    public double? Pierce2Recoil { get; set; }

    public string? Pierce2Reload { get; set; }

    public int Pierce3Clip { get; set; }

    public double? Pierce3Rapid { get; set; }

    public double? Pierce3Recoil { get; set; }

    public string? Pierce3Reload { get; set; }

    public int Spread1Clip { get; set; }

    public string? Spread1Rapid { get; set; }

    public double? Spread1Recoil { get; set; }

    public string? Spread1Reload { get; set; }

    public int Spread2Clip { get; set; }

    public string? Spread2Rapid { get; set; }

    public double? Spread2Recoil { get; set; }

    public string? Spread2Reload { get; set; }

    public int Spread3Clip { get; set; }

    public double? Spread3Rapid { get; set; }

    public double? Spread3Recoil { get; set; }

    public string? Spread3Reload { get; set; }

    public int Sticky1Clip { get; set; }

    public double? Sticky1Recoil { get; set; }

    public string? Sticky1Reload { get; set; }

    public int Sticky2Clip { get; set; }

    public double? Sticky2Recoil { get; set; }

    public string? Sticky2Reload { get; set; }

    public int Sticky3Clip { get; set; }

    public double? Sticky3Recoil { get; set; }

    public string? Sticky3Reload { get; set; }

    public int Cluster1Clip { get; set; }

    public double? Cluster1Recoil { get; set; }

    public string? Cluster1Reload { get; set; }

    public int Cluster2Clip { get; set; }

    public double? Cluster2Recoil { get; set; }

    public string? Cluster2Reload { get; set; }

    public int Cluster3Clip { get; set; }

    public double? Cluster3Recoil { get; set; }

    public string? Cluster3Reload { get; set; }

    public int Recover1Clip { get; set; }

    public double? Recover1Recoil { get; set; }

    public string? Recover1Reload { get; set; }

    public int Recover2Clip { get; set; }

    public double? Recover2Recoil { get; set; }

    public string? Recover2Reload { get; set; }

    public int Poison1Clip { get; set; }

    public double? Poison1Recoil { get; set; }

    public string? Poison1Reload { get; set; }

    public int Poison2Clip { get; set; }

    public double? Poison2Recoil { get; set; }

    public string? Poison2Reload { get; set; }

    public int Paralysis1Clip { get; set; }

    public double? Paralysis1Recoil { get; set; }

    public string? Paralysis1Reload { get; set; }

    public int Paralysis2Clip { get; set; }

    public double? Paralysis2Recoil { get; set; }

    public string? Paralysis2Reload { get; set; }

    public int Sleep1Clip { get; set; }

    public double? Sleep1Recoil { get; set; }

    public string? Sleep1Reload { get; set; }

    public int Sleep2Clip { get; set; }

    public double? Sleep2Recoil { get; set; }

    public string? Sleep2Reload { get; set; }

    public int Exhaust1Clip { get; set; }

    public string? Exhaust1Rapid { get; set; }

    public double? Exhaust1Recoil { get; set; }

    public string? Exhaust1Reload { get; set; }

    public int Exhaust2Clip { get; set; }

    public double? Exhaust2Rapid { get; set; }

    public double? Exhaust2Recoil { get; set; }

    public string? Exhaust2Reload { get; set; }

    public int FlamingClip { get; set; }

    public string? FlamingRapid { get; set; }

    public double? FlamingRecoil { get; set; }

    public string? FlamingReload { get; set; }

    public int WaterClip { get; set; }

    public string? WaterRapid { get; set; }

    public double? WaterRecoil { get; set; }

    public string? WaterReload { get; set; }

    public int FreezeClip { get; set; }

    public string? FreezeRapid { get; set; }

    public double? FreezeRecoil { get; set; }

    public string? FreezeReload { get; set; }

    public int ThunderClip { get; set; }

    public string? ThunderRapid { get; set; }

    public double? ThunderRecoil { get; set; }

    public string? ThunderReload { get; set; }

    public int DragonClip { get; set; }

    public double? DragonRecoil { get; set; }

    public string? DragonReload { get; set; }

    public int SlicingClip { get; set; }

    public double? SlicingRecoil { get; set; }

    public string? SlicingReload { get; set; }

    public int WyvernClip { get; set; }

    public string? WyvernReload { get; set; }

    public int DemonClip { get; set; }

    public double? DemonRecoil { get; set; }

    public string? DemonReload { get; set; }

    public int ArmorClip { get; set; }

    public double? ArmorRecoil { get; set; }

    public string? ArmorReload { get; set; }

    public int TranqClip { get; set; }

    public int TranqRecoil { get; set; }

    public string TranqReload { get; set; } = null!;
}
