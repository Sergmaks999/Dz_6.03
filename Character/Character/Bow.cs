using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Bow : IWeapon
{
    public int Range { get; set; }
    public int Accuracy { get; set; }
    public static string WeaponType => "Лук";
    public int WeaponPower { get; set; }
    public string SpecialAbility { get; set; }

    public Bow(int range, int accuracy, int weaponPower, string specialAbility)
    {
        Range = range;
        Accuracy = accuracy;
        WeaponPower = weaponPower;
        SpecialAbility = specialAbility;
    }
}