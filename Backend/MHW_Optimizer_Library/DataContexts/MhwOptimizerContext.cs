using MHW_Optimizer_Library.Models.Scaffold;
using Microsoft.EntityFrameworkCore;

namespace MHW_Optimizer_Library.DataContexts;

public partial class MhwOptimizerContext : DbContext
{
    public MhwOptimizerContext()
    {
    }

    public MhwOptimizerContext(DbContextOptions<MhwOptimizerContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Armor> Armors { get; set; }

    public virtual DbSet<ArmorCraft> ArmorCrafts { get; set; }

    public virtual DbSet<ArmorSkill> ArmorSkills { get; set; }

    public virtual DbSet<Armorset> Armorsets { get; set; }

    public virtual DbSet<ArmorsetBonu> ArmorsetBonus { get; set; }

    public virtual DbSet<Charm> Charms { get; set; }

    public virtual DbSet<CharmCraft> CharmCrafts { get; set; }

    public virtual DbSet<Decoration> Decorations { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemCombination> ItemCombinations { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<LocationCamp> LocationCamps { get; set; }

    public virtual DbSet<LocationGathering> LocationGatherings { get; set; }

    public virtual DbSet<LocationItem> LocationItems { get; set; }

    public virtual DbSet<Monster> Monsters { get; set; }

    public virtual DbSet<MonsterAilment> MonsterAilments { get; set; }

    public virtual DbSet<MonsterBreak> MonsterBreaks { get; set; }

    public virtual DbSet<MonsterHabitat> MonsterHabitats { get; set; }

    public virtual DbSet<MonsterHitzone> MonsterHitzones { get; set; }

    public virtual DbSet<MonsterReward> MonsterRewards { get; set; }

    public virtual DbSet<MonsterWeakness> MonsterWeaknesses { get; set; }

    public virtual DbSet<Quest> Quests { get; set; }

    public virtual DbSet<QuestMonster> QuestMonsters { get; set; }

    public virtual DbSet<QuestReward> QuestRewards { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    public virtual DbSet<SkillLevel> SkillLevels { get; set; }

    public virtual DbSet<Tool> Tools { get; set; }

    public virtual DbSet<Weapon> Weapons { get; set; }

    public virtual DbSet<WeaponAmmo> WeaponAmmos { get; set; }

    public virtual DbSet<WeaponBow> WeaponBows { get; set; }

    public virtual DbSet<WeaponCraft> WeaponCrafts { get; set; }

    public virtual DbSet<WeaponKinsect> WeaponKinsects { get; set; }

    public virtual DbSet<WeaponKinsectCraft> WeaponKinsectCrafts { get; set; }

    public virtual DbSet<WeaponMelody> WeaponMelodies { get; set; }

    public virtual DbSet<WeaponMelodyNote> WeaponMelodyNotes { get; set; }

    public virtual DbSet<WeaponSharpness> WeaponSharpnesses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=DESKTOP-UK889OC\\SQLEXPRESS;Database=mhw_optimizer;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Armor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Armor__3214EC07CF17DF38");

            entity.ToTable("Armor");

            entity.Property(e => e.ArmorId).HasColumnName("Armor_Id");
            entity.Property(e => e.DefenseAugmentMax).HasColumnName("Defense_Augment_Max");
            entity.Property(e => e.DefenseBase).HasColumnName("Defense_Base");
            entity.Property(e => e.DefenseDragon).HasColumnName("Defense_Dragon");
            entity.Property(e => e.DefenseFire).HasColumnName("Defense_Fire");
            entity.Property(e => e.DefenseIce).HasColumnName("Defense_Ice");
            entity.Property(e => e.DefenseMax).HasColumnName("Defense_Max");
            entity.Property(e => e.DefenseThunder).HasColumnName("Defense_Thunder");
            entity.Property(e => e.DefenseWater).HasColumnName("Defense_Water");
            entity.Property(e => e.Slot1).HasColumnName("Slot_1");
            entity.Property(e => e.Slot2).HasColumnName("Slot_2");
            entity.Property(e => e.Slot3).HasColumnName("Slot_3");
        });

        modelBuilder.Entity<ArmorCraft>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Armor_Cr__3214EC07AFEE7723");

            entity.ToTable("Armor_Craft");

            entity.Property(e => e.Item1Name).HasColumnName("Item1_Name");
            entity.Property(e => e.Item1Qty).HasColumnName("Item1_Qty");
            entity.Property(e => e.Item2Name).HasColumnName("Item2_Name");
            entity.Property(e => e.Item2Qty).HasColumnName("Item2_Qty");
            entity.Property(e => e.Item3Name).HasColumnName("Item3_Name");
            entity.Property(e => e.Item3Qty).HasColumnName("Item3_Qty");
            entity.Property(e => e.Item4Name).HasColumnName("Item4_Name");
            entity.Property(e => e.Item4Qty).HasColumnName("Item4_Qty");
        });

        modelBuilder.Entity<ArmorSkill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Armor_Sk__3214EC0753967998");

            entity.ToTable("Armor_Skills");

            entity.Property(e => e.Skill1Level).HasColumnName("Skill1_Level");
            entity.Property(e => e.Skill1Name).HasColumnName("Skill1_Name");
            entity.Property(e => e.Skill2Level).HasColumnName("Skill2_Level");
            entity.Property(e => e.Skill2Name).HasColumnName("Skill2_Name");
        });

        modelBuilder.Entity<Armorset>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Armorset__3214EC07534B7DC7");

            entity.ToTable("Armorset");
        });

        modelBuilder.Entity<ArmorsetBonu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Armorset__3214EC07808EC7F0");

            entity.ToTable("Armorset_Bonus");

            entity.Property(e => e.Skill1Name).HasColumnName("Skill1_Name");
            entity.Property(e => e.Skill1Required).HasColumnName("Skill1_Required");
            entity.Property(e => e.Skill2Name).HasColumnName("Skill2_Name");
            entity.Property(e => e.Skill2Required).HasColumnName("Skill2_Required");
        });

        modelBuilder.Entity<Charm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Charm__3214EC0743D5B368");

            entity.ToTable("Charm");

            entity.Property(e => e.CharmId).HasColumnName("Charm_Id");
            entity.Property(e => e.Skill1Level).HasColumnName("Skill1_Level");
            entity.Property(e => e.Skill1Name).HasColumnName("Skill1_Name");
            entity.Property(e => e.Skill2Level).HasColumnName("Skill2_Level");
            entity.Property(e => e.Skill2Name).HasColumnName("Skill2_Name");
        });

        modelBuilder.Entity<CharmCraft>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Charm_Cr__3214EC07E1475D6F");

            entity.ToTable("Charm_Craft");

            entity.Property(e => e.Item1Name).HasColumnName("Item1_Name");
            entity.Property(e => e.Item1Qty).HasColumnName("Item1_Qty");
            entity.Property(e => e.Item2Name).HasColumnName("Item2_Name");
            entity.Property(e => e.Item2Qty).HasColumnName("Item2_Qty");
            entity.Property(e => e.Item3Name).HasColumnName("Item3_Name");
            entity.Property(e => e.Item3Qty).HasColumnName("Item3_Qty");
            entity.Property(e => e.Item4Name).HasColumnName("Item4_Name");
            entity.Property(e => e.Item4Qty).HasColumnName("Item4_Qty");
        });

        modelBuilder.Entity<Decoration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Decorati__3214EC07BDB8AF53");

            entity.ToTable("Decoration");

            entity.Property(e => e.DecorationId).HasColumnName("Decoration_Id");
            entity.Property(e => e.IconColor).HasColumnName("Icon_Color");
            entity.Property(e => e.Skill1Level).HasColumnName("Skill1_Level");
            entity.Property(e => e.Skill1Name).HasColumnName("Skill1_Name");
            entity.Property(e => e.Skill2Level).HasColumnName("Skill2_Level");
            entity.Property(e => e.Skill2Name).HasColumnName("Skill2_Name");
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Item__3214EC0756A02471");

            entity.ToTable("Item");

            entity.Property(e => e.BuyPrice).HasColumnName("Buy_Price");
            entity.Property(e => e.CarryLimit).HasColumnName("Carry_Limit");
            entity.Property(e => e.IconColor).HasColumnName("Icon_Color");
            entity.Property(e => e.IconName).HasColumnName("Icon_Name");
            entity.Property(e => e.ItemId).HasColumnName("Item_Id");
            entity.Property(e => e.SellPrice).HasColumnName("Sell_Price");
        });

        modelBuilder.Entity<ItemCombination>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Item_Com__3214EC071A5FBE4E");

            entity.ToTable("Item_Combination");

            entity.Property(e => e.ItemCombinationId).HasColumnName("Item_Combination_Id");
        });

        modelBuilder.Entity<Location>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Location__3214EC07B6B36742");

            entity.ToTable("Location");

            entity.Property(e => e.LocationId).HasColumnName("Location_Id");
        });

        modelBuilder.Entity<LocationCamp>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Location__3214EC07F4CB4906");

            entity.ToTable("Location_Camps");

            entity.Property(e => e.CampName).HasColumnName("Camp_Name");
        });

        modelBuilder.Entity<LocationGathering>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Location__3214EC07D43396FE");

            entity.ToTable("Location_Gathering");
        });

        modelBuilder.Entity<LocationItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Location__3214EC075AFAA754");

            entity.ToTable("Location_Items");

            entity.Property(e => e.ItemLang).HasColumnName("Item_Lang");
        });

        modelBuilder.Entity<Monster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Monster__3214EC07590DF78B");

            entity.ToTable("Monster");

            entity.Property(e => e.MonsterId).HasColumnName("Monster_Id");
            entity.Property(e => e.PitfallTrap).HasColumnName("Pitfall_Trap");
            entity.Property(e => e.ShockTrap).HasColumnName("Shock_Trap");
            entity.Property(e => e.VineTrap).HasColumnName("Vine_Trap");
        });

        modelBuilder.Entity<MonsterAilment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Monster___3214EC07563CDC3C");

            entity.ToTable("Monster_Ailments");

            entity.Property(e => e.DefenseDown).HasColumnName("Defense_Down");
        });

        modelBuilder.Entity<MonsterBreak>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Monster___3214EC0737629DEC");

            entity.ToTable("Monster_Breaks");

            entity.Property(e => e.PartJa).HasColumnName("Part_Ja");
        });

        modelBuilder.Entity<MonsterHabitat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Monster___3214EC0752930C42");

            entity.ToTable("Monster_Habitats");

            entity.Property(e => e.MoveArea).HasColumnName("Move_Area");
            entity.Property(e => e.RestArea).HasColumnName("Rest_Area");
            entity.Property(e => e.StartArea).HasColumnName("Start_Area");
        });

        modelBuilder.Entity<MonsterHitzone>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Monster___3214EC0728F5AE9F");

            entity.ToTable("Monster_Hitzones");
        });

        modelBuilder.Entity<MonsterReward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Monster___3214EC07B054327C");

            entity.ToTable("Monster_Rewards");
        });

        modelBuilder.Entity<MonsterWeakness>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Monster___3214EC0799767692");

            entity.ToTable("Monster_Weaknesses");

            entity.Property(e => e.AltDescription).HasColumnName("Alt_Description");
        });

        modelBuilder.Entity<Quest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quest__3214EC077686390C");

            entity.ToTable("Quest");

            entity.Property(e => e.QuestId).HasColumnName("Quest_Id");
            entity.Property(e => e.QuestType).HasColumnName("Quest_Type");
        });

        modelBuilder.Entity<QuestMonster>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quest_Mo__3214EC0709D0EBFB");

            entity.ToTable("Quest_Monsters");

            entity.Property(e => e.IsObjective).HasColumnName("Is_Objective");
            entity.Property(e => e.QuestId).HasColumnName("Quest_Id");
        });

        modelBuilder.Entity<QuestReward>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quest_Re__3214EC07966F46F4");

            entity.ToTable("Quest_Rewards");

            entity.Property(e => e.QuestId).HasColumnName("Quest_Id");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Skill__3214EC078095025E");

            entity.ToTable("Skill");

            entity.Property(e => e.IconColor).HasColumnName("Icon_Color");
        });

        modelBuilder.Entity<SkillLevel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Skill_Le__3214EC075857F709");

            entity.ToTable("Skill_Levels");
        });

        modelBuilder.Entity<Tool>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Tool__3214EC070398B505");

            entity.ToTable("Tool");

            entity.Property(e => e.DurationUpgraded).HasColumnName("Duration_Upgraded");
            entity.Property(e => e.Slot1).HasColumnName("Slot_1");
            entity.Property(e => e.Slot2).HasColumnName("Slot_2");
            entity.Property(e => e.Slot3).HasColumnName("Slot_3");
            entity.Property(e => e.ToolId).HasColumnName("Tool_Id");
            entity.Property(e => e.ToolType).HasColumnName("Tool_Type");
        });

        modelBuilder.Entity<Weapon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon__3214EC071FB48621");

            entity.ToTable("Weapon");

            entity.Property(e => e.AmmoConfig).HasColumnName("Ammo_Config");
            entity.Property(e => e.Element1Attack).HasColumnName("Element1_Attack");
            entity.Property(e => e.Element2Attack).HasColumnName("Element2_Attack");
            entity.Property(e => e.ElementHidden).HasColumnName("Element_Hidden");
            entity.Property(e => e.KinsectBonus).HasColumnName("Kinsect_Bonus");
            entity.Property(e => e.PhialPower).HasColumnName("Phial_Power");
            entity.Property(e => e.ShellingLevel).HasColumnName("Shelling_Level");
            entity.Property(e => e.Slot1).HasColumnName("Slot_1");
            entity.Property(e => e.Slot2).HasColumnName("Slot_2");
            entity.Property(e => e.Slot3).HasColumnName("Slot_3");
            entity.Property(e => e.WeaponId).HasColumnName("Weapon_Id");
            entity.Property(e => e.WeaponType).HasColumnName("Weapon_Type");
        });

        modelBuilder.Entity<WeaponAmmo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon_A__3214EC07C1B8DB71");

            entity.ToTable("Weapon_Ammo");

            entity.Property(e => e.ArmorClip).HasColumnName("Armor_Clip");
            entity.Property(e => e.ArmorRecoil).HasColumnName("Armor_Recoil");
            entity.Property(e => e.ArmorReload).HasColumnName("Armor_Reload");
            entity.Property(e => e.Cluster1Clip).HasColumnName("Cluster1_Clip");
            entity.Property(e => e.Cluster1Recoil).HasColumnName("Cluster1_Recoil");
            entity.Property(e => e.Cluster1Reload).HasColumnName("Cluster1_Reload");
            entity.Property(e => e.Cluster2Clip).HasColumnName("Cluster2_Clip");
            entity.Property(e => e.Cluster2Recoil).HasColumnName("Cluster2_Recoil");
            entity.Property(e => e.Cluster2Reload).HasColumnName("Cluster2_Reload");
            entity.Property(e => e.Cluster3Clip).HasColumnName("Cluster3_Clip");
            entity.Property(e => e.Cluster3Recoil).HasColumnName("Cluster3_Recoil");
            entity.Property(e => e.Cluster3Reload).HasColumnName("Cluster3_Reload");
            entity.Property(e => e.DemonClip).HasColumnName("Demon_Clip");
            entity.Property(e => e.DemonRecoil).HasColumnName("Demon_Recoil");
            entity.Property(e => e.DemonReload).HasColumnName("Demon_Reload");
            entity.Property(e => e.DragonClip).HasColumnName("Dragon_Clip");
            entity.Property(e => e.DragonRecoil).HasColumnName("Dragon_Recoil");
            entity.Property(e => e.DragonReload).HasColumnName("Dragon_Reload");
            entity.Property(e => e.Exhaust1Clip).HasColumnName("Exhaust1_Clip");
            entity.Property(e => e.Exhaust1Rapid).HasColumnName("Exhaust1_Rapid");
            entity.Property(e => e.Exhaust1Recoil).HasColumnName("Exhaust1_Recoil");
            entity.Property(e => e.Exhaust1Reload).HasColumnName("Exhaust1_Reload");
            entity.Property(e => e.Exhaust2Clip).HasColumnName("Exhaust2_Clip");
            entity.Property(e => e.Exhaust2Rapid).HasColumnName("Exhaust2_Rapid");
            entity.Property(e => e.Exhaust2Recoil).HasColumnName("Exhaust2_Recoil");
            entity.Property(e => e.Exhaust2Reload).HasColumnName("Exhaust2_Reload");
            entity.Property(e => e.FlamingClip).HasColumnName("Flaming_Clip");
            entity.Property(e => e.FlamingRapid).HasColumnName("Flaming_Rapid");
            entity.Property(e => e.FlamingRecoil).HasColumnName("Flaming_Recoil");
            entity.Property(e => e.FlamingReload).HasColumnName("Flaming_Reload");
            entity.Property(e => e.FreezeClip).HasColumnName("Freeze_Clip");
            entity.Property(e => e.FreezeRapid).HasColumnName("Freeze_Rapid");
            entity.Property(e => e.FreezeRecoil).HasColumnName("Freeze_Recoil");
            entity.Property(e => e.FreezeReload).HasColumnName("Freeze_Reload");
            entity.Property(e => e.Normal1Clip).HasColumnName("Normal1_Clip");
            entity.Property(e => e.Normal1Rapid).HasColumnName("Normal1_Rapid");
            entity.Property(e => e.Normal1Recoil).HasColumnName("Normal1_Recoil");
            entity.Property(e => e.Normal1Reload).HasColumnName("Normal1_Reload");
            entity.Property(e => e.Normal2Clip).HasColumnName("Normal2_Clip");
            entity.Property(e => e.Normal2Rapid).HasColumnName("Normal2_Rapid");
            entity.Property(e => e.Normal2Recoil).HasColumnName("Normal2_Recoil");
            entity.Property(e => e.Normal2Reload).HasColumnName("Normal2_Reload");
            entity.Property(e => e.Normal3Clip).HasColumnName("Normal3_Clip");
            entity.Property(e => e.Normal3Rapid).HasColumnName("Normal3_Rapid");
            entity.Property(e => e.Normal3Recoil).HasColumnName("Normal3_Recoil");
            entity.Property(e => e.Normal3Reload).HasColumnName("Normal3_Reload");
            entity.Property(e => e.Paralysis1Clip).HasColumnName("Paralysis1_Clip");
            entity.Property(e => e.Paralysis1Recoil).HasColumnName("Paralysis1_Recoil");
            entity.Property(e => e.Paralysis1Reload).HasColumnName("Paralysis1_Reload");
            entity.Property(e => e.Paralysis2Clip).HasColumnName("Paralysis2_Clip");
            entity.Property(e => e.Paralysis2Recoil).HasColumnName("Paralysis2_Recoil");
            entity.Property(e => e.Paralysis2Reload).HasColumnName("Paralysis2_Reload");
            entity.Property(e => e.Pierce1Clip).HasColumnName("Pierce1_Clip");
            entity.Property(e => e.Pierce1Rapid).HasColumnName("Pierce1_Rapid");
            entity.Property(e => e.Pierce1Recoil).HasColumnName("Pierce1_Recoil");
            entity.Property(e => e.Pierce1Reload).HasColumnName("Pierce1_Reload");
            entity.Property(e => e.Pierce2Clip).HasColumnName("Pierce2_Clip");
            entity.Property(e => e.Pierce2Rapid).HasColumnName("Pierce2_Rapid");
            entity.Property(e => e.Pierce2Recoil).HasColumnName("Pierce2_Recoil");
            entity.Property(e => e.Pierce2Reload).HasColumnName("Pierce2_Reload");
            entity.Property(e => e.Pierce3Clip).HasColumnName("Pierce3_Clip");
            entity.Property(e => e.Pierce3Rapid).HasColumnName("Pierce3_Rapid");
            entity.Property(e => e.Pierce3Recoil).HasColumnName("Pierce3_Recoil");
            entity.Property(e => e.Pierce3Reload).HasColumnName("Pierce3_Reload");
            entity.Property(e => e.Poison1Clip).HasColumnName("Poison1_Clip");
            entity.Property(e => e.Poison1Recoil).HasColumnName("Poison1_Recoil");
            entity.Property(e => e.Poison1Reload).HasColumnName("Poison1_Reload");
            entity.Property(e => e.Poison2Clip).HasColumnName("Poison2_Clip");
            entity.Property(e => e.Poison2Recoil).HasColumnName("Poison2_Recoil");
            entity.Property(e => e.Poison2Reload).HasColumnName("Poison2_Reload");
            entity.Property(e => e.Recover1Clip).HasColumnName("Recover1_Clip");
            entity.Property(e => e.Recover1Recoil).HasColumnName("Recover1_Recoil");
            entity.Property(e => e.Recover1Reload).HasColumnName("Recover1_Reload");
            entity.Property(e => e.Recover2Clip).HasColumnName("Recover2_Clip");
            entity.Property(e => e.Recover2Recoil).HasColumnName("Recover2_Recoil");
            entity.Property(e => e.Recover2Reload).HasColumnName("Recover2_Reload");
            entity.Property(e => e.Sleep1Clip).HasColumnName("Sleep1_Clip");
            entity.Property(e => e.Sleep1Recoil).HasColumnName("Sleep1_Recoil");
            entity.Property(e => e.Sleep1Reload).HasColumnName("Sleep1_Reload");
            entity.Property(e => e.Sleep2Clip).HasColumnName("Sleep2_Clip");
            entity.Property(e => e.Sleep2Recoil).HasColumnName("Sleep2_Recoil");
            entity.Property(e => e.Sleep2Reload).HasColumnName("Sleep2_Reload");
            entity.Property(e => e.SlicingClip).HasColumnName("Slicing_Clip");
            entity.Property(e => e.SlicingRecoil).HasColumnName("Slicing_Recoil");
            entity.Property(e => e.SlicingReload).HasColumnName("Slicing_Reload");
            entity.Property(e => e.Spread1Clip).HasColumnName("Spread1_Clip");
            entity.Property(e => e.Spread1Rapid).HasColumnName("Spread1_Rapid");
            entity.Property(e => e.Spread1Recoil).HasColumnName("Spread1_Recoil");
            entity.Property(e => e.Spread1Reload).HasColumnName("Spread1_Reload");
            entity.Property(e => e.Spread2Clip).HasColumnName("Spread2_Clip");
            entity.Property(e => e.Spread2Rapid).HasColumnName("Spread2_Rapid");
            entity.Property(e => e.Spread2Recoil).HasColumnName("Spread2_Recoil");
            entity.Property(e => e.Spread2Reload).HasColumnName("Spread2_Reload");
            entity.Property(e => e.Spread3Clip).HasColumnName("Spread3_Clip");
            entity.Property(e => e.Spread3Rapid).HasColumnName("Spread3_Rapid");
            entity.Property(e => e.Spread3Recoil).HasColumnName("Spread3_Recoil");
            entity.Property(e => e.Spread3Reload).HasColumnName("Spread3_Reload");
            entity.Property(e => e.Sticky1Clip).HasColumnName("Sticky1_Clip");
            entity.Property(e => e.Sticky1Recoil).HasColumnName("Sticky1_Recoil");
            entity.Property(e => e.Sticky1Reload).HasColumnName("Sticky1_Reload");
            entity.Property(e => e.Sticky2Clip).HasColumnName("Sticky2_Clip");
            entity.Property(e => e.Sticky2Recoil).HasColumnName("Sticky2_Recoil");
            entity.Property(e => e.Sticky2Reload).HasColumnName("Sticky2_Reload");
            entity.Property(e => e.Sticky3Clip).HasColumnName("Sticky3_Clip");
            entity.Property(e => e.Sticky3Recoil).HasColumnName("Sticky3_Recoil");
            entity.Property(e => e.Sticky3Reload).HasColumnName("Sticky3_Reload");
            entity.Property(e => e.ThunderClip).HasColumnName("Thunder_Clip");
            entity.Property(e => e.ThunderRapid).HasColumnName("Thunder_Rapid");
            entity.Property(e => e.ThunderRecoil).HasColumnName("Thunder_Recoil");
            entity.Property(e => e.ThunderReload).HasColumnName("Thunder_Reload");
            entity.Property(e => e.TranqClip).HasColumnName("Tranq_Clip");
            entity.Property(e => e.TranqRecoil).HasColumnName("Tranq_Recoil");
            entity.Property(e => e.TranqReload).HasColumnName("Tranq_Reload");
            entity.Property(e => e.WaterClip).HasColumnName("Water_Clip");
            entity.Property(e => e.WaterRapid).HasColumnName("Water_Rapid");
            entity.Property(e => e.WaterRecoil).HasColumnName("Water_Recoil");
            entity.Property(e => e.WaterReload).HasColumnName("Water_Reload");
            entity.Property(e => e.WyvernClip).HasColumnName("Wyvern_Clip");
            entity.Property(e => e.WyvernReload).HasColumnName("Wyvern_Reload");
        });

        modelBuilder.Entity<WeaponBow>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon_B__3214EC07F83D281E");

            entity.ToTable("Weapon_Bow");

            entity.Property(e => e.WeaponType).HasColumnName("Weapon_Type");
        });

        modelBuilder.Entity<WeaponCraft>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon_C__3214EC07309556CD");

            entity.ToTable("Weapon_Craft");

            entity.Property(e => e.Item1Name).HasColumnName("Item1_Name");
            entity.Property(e => e.Item1Qty).HasColumnName("Item1_Qty");
            entity.Property(e => e.Item2Name).HasColumnName("Item2_Name");
            entity.Property(e => e.Item2Qty).HasColumnName("Item2_Qty");
            entity.Property(e => e.Item3Name).HasColumnName("Item3_Name");
            entity.Property(e => e.Item3Qty).HasColumnName("Item3_Qty");
            entity.Property(e => e.Item4Name).HasColumnName("Item4_Name");
            entity.Property(e => e.Item4Qty).HasColumnName("Item4_Qty");
            entity.Property(e => e.WeaponType).HasColumnName("Weapon_Type");
        });

        modelBuilder.Entity<WeaponKinsect>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon_K__3214EC0749702932");

            entity.ToTable("Weapon_Kinsect");

            entity.Property(e => e.AttackType).HasColumnName("Attack_Type");
            entity.Property(e => e.DustEffect).HasColumnName("Dust_Effect");
            entity.Property(e => e.WeaponKinsectId).HasColumnName("Weapon_Kinsect_Id");
        });

        modelBuilder.Entity<WeaponKinsectCraft>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon_K__3214EC07CA768887");

            entity.ToTable("Weapon_Kinsect_Craft");

            entity.Property(e => e.Item1Name).HasColumnName("Item1_Name");
            entity.Property(e => e.Item1Qty).HasColumnName("Item1_Qty");
            entity.Property(e => e.Item2Name).HasColumnName("Item2_Name");
            entity.Property(e => e.Item2Qty).HasColumnName("Item2_Qty");
            entity.Property(e => e.Item3Name).HasColumnName("Item3_Name");
            entity.Property(e => e.Item3Qty).HasColumnName("Item3_Qty");
            entity.Property(e => e.Item4Name).HasColumnName("Item4_Name");
            entity.Property(e => e.Item4Qty).HasColumnName("Item4_Qty");
        });

        modelBuilder.Entity<WeaponMelody>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon_M__3214EC07B9B2233F");

            entity.ToTable("Weapon_Melody");

            entity.Property(e => e.BaseDuration).HasColumnName("Base_Duration");
            entity.Property(e => e.BaseExtension).HasColumnName("Base_Extension");
            entity.Property(e => e.M1Duration).HasColumnName("M1_Duration");
            entity.Property(e => e.M1Extension).HasColumnName("M1_Extension");
            entity.Property(e => e.M2Duration).HasColumnName("M2_Duration");
            entity.Property(e => e.M2Extension).HasColumnName("M2_Extension");
            entity.Property(e => e.WeaponMelodyId).HasColumnName("Weapon_Melody_Id");
        });

        modelBuilder.Entity<WeaponMelodyNote>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon_M__3214EC071C7607E9");

            entity.ToTable("Weapon_Melody_Notes");
        });

        modelBuilder.Entity<WeaponSharpness>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Weapon_S__3214EC0770D988E2");

            entity.ToTable("Weapon_Sharpness");

            entity.Property(e => e.WeaponType).HasColumnName("Weapon_Type");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
