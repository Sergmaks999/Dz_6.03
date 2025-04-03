using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class GameCharacter<T> where T : IWeapon
{
    public string CharacterName { get; set; }
    public string CharacterRace { get; set; }
    public T Weapon { get; set; }
    public int CharacterStrength { get; set; }

    public GameCharacter(string characterName, string characterRace, T weapon, int characterStrength)
    {
        CharacterName = characterName;
        CharacterRace = characterRace;
        Weapon = weapon;
        CharacterStrength = characterStrength;
    }

    public string GetCharacterInfo()
    {
        string weaponInfo = "";

        if (Weapon is Sword sword)
        {
            weaponInfo = $"Тип: {Sword.WeaponType}, Качество: {sword.Quality}, Сила: {sword.WeaponPower}, Особенность: {sword.SpecialAbility}";
        }
        else if (Weapon is Bow bow)
        {
            weaponInfo = $"Тип: {Bow.WeaponType}, Дальность: {bow.Range}, Точность: {bow.Accuracy}, Сила: {bow.WeaponPower}, Особенность: {bow.SpecialAbility}";
        }
        else
        {
            weaponInfo = "Неизвестный тип оружия";
        }

        return $"Имя: {CharacterName}, Раса: {CharacterRace}, {weaponInfo}, Сила персонажа: {CharacterStrength}";
    }

    public int CalculateTotalStrength()
    {
        return CharacterStrength + Weapon.WeaponPower;
    }
}