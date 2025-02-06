using MHW_Optimizer_Library.Models.Scaffold;

namespace MHW_Optimizer_Library.Models.Entity
{
    public class BuildProfile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Charm Charm { get; set; }

        public Weapon Weapon { get; set; }

        public ICollection<WeaponAmmo>? WeaponAmmos { get; set; }

        public ICollection<Tool> Tools { get; set; }

        public ICollection<Item> Items { get; set; }

        public ICollection<Decoration> Decorations { get; set; }

        public WeaponKinsect? WeaponKinsect { get; set; }
    }
}
