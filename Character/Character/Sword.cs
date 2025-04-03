using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Sword : IWeapon
{
    public string Quality { get; set; }
    public static string WeaponType => "Меч";
    public int WeaponPower { get; set; }
    public string SpecialAbility { get; set; }

    public Sword(string quality, int weaponPower, string specialAbility)
    {
        Quality = quality;
        WeaponPower = weaponPower;
        SpecialAbility = specialAbility;
    }
}