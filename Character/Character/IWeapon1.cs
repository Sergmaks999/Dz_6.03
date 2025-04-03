using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IWeapon
{
    static string WeaponType { get; }
    int WeaponPower { get; }
    string SpecialAbility { get; }
}
