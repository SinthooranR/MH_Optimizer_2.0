using MHW_Optimizer_Library.Models.Scaffold;

namespace MHW_Optimizer_Library.Models.Dto
{
    public class WeaponDetails
    {
        public Weapon Weapon { get; set; }

        public WeaponSharpness Weapon_Sharpness { get; set; }

        public ICollection<WeaponKinsect> Weapon_Kinsect { get; set; }

        public ICollection<WeaponKinsectCraft> Weapon_Kinsect_Craft { get; set; }

        public WeaponBow Weapon_Bow { get; set; }

        public WeaponAmmo Weapon_Ammo { get; set; }


    }
}
