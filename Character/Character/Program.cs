using System;

public class Character
{
    public static void Main(string[] args)
    {
        Sword sword = new Sword("Уникальное", 50, "Увеличение шанса критического удара");
        GameCharacter<Sword> warrior = new GameCharacter<Sword>("Артур", "Человек", sword, 80);

        Console.WriteLine(warrior.GetCharacterInfo());
        Console.WriteLine($"Суммарная сила: {warrior.CalculateTotalStrength()}");

        Bow bow = new Bow(90, 75, 40, "Шанс оглушения");
        GameCharacter<Bow> archer = new GameCharacter<Bow>("", "Эльф", bow, 70);

        Console.WriteLine(archer.GetCharacterInfo());
        Console.WriteLine($"Суммарная сила: {archer.CalculateTotalStrength()}");
    }
}