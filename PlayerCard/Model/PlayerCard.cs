namespace PlayerCard.Model;

public record PlayerCard
{
    public Guid Id { get; set; }
    
    public string? CharacterName { get; set; }
    
    public CharacterInfo? CharacterInfo { get; set; }

    public static Characteristic Strength { get; set; } =
        new (
            "Strength",
            new List<Skill>
            {
                new ("Athletics")
            });

    public static Characteristic Dexterity { get; set; } =
        new (
            "Dexterity",
            new List<Skill>
            {
                new ("Acrobatics"),
                new ("Sleight of Hand"),
                new ("Stealth")
            });

    public static Characteristic Constitution { get; set; } =
        new(
            "Constitution",
            new List<Skill>());

    public static Characteristic Intelligence { get; set; } =
        new (
            "Intelligence",
            new List<Skill>
            {
                new ("Arcana"),
                new ("History"),
                new ("Investigation"),
                new ("Nature"),
                new ("Religion")
            });

    public static Characteristic Wisdom { get; set; } =
        new (
            "Wisdom",
            new List<Skill>
            {
                new ("Animal Handling"),
                new ("Insight"),
                new ("Medicine"),
                new ("Perception"),
                new ("Survival")
            });

    public static Characteristic Charisma { get; set; } =
        new (
            "Charisma",
            new List<Skill>
            {
                new ("Deception"),
                new ("Intimidation"),
                new ("Performance"),
                new ("Persuasion")
            });
    
    public int ArmorClass { get; set; }
    public int Initiative { get; set; }
    public int Speed { get; set; }
    public int MaxHitPoints { get; set; }
    public int CurrentHitPoints { get; set; }
    public int TemporaryHitPoints { get; set; }
    public Dice HitDice { get; set; }
    public int MaxHitDices { get; set; }
    public int CurrentHitDices { get; set; }
    public DeathSaves? DeathSaves { get; set; }
}

public record CharacterInfo
{
    public Class Class { get; set; }
    public int Level { get; set; }
    public Race Race { get; set; }
    public Background Background { get; set; }
    public Alignment Alignment { get; set; }
    public string? PlayerName { get; set; }
    public int ExperiencePoints { get; set; }
}

public record Characteristic(string? Name, List<Skill>? Skills)
{
    public string? Name { get; }

    public List<Skill>? Skills { get; }
    
    public int Value { get; set; }
    
    public int ValueModificator { get; set; }
}

public record Skill(string? Name)
{
    public string? Name { get; }
    
    public int Modificator { get; set; }
    
    public bool IsHave { get; set; }
}

public record DeathSaves
{
    public int Successes { get; set; }
    public int Failures { get; set; }
}

public enum Class
{
    
}

public enum Race
{
    
}

public enum Background
{
    
}

public enum Alignment
{
    LawfulGood,
    NeutralGood,
    ChaoticGood,
    LawfulNeutral,
    Neutral,
    ChaoticNeutral,
    LawfulEvil,
    NeutralEvil,
    ChaoticEvil
}

public enum Dice
{
    D4 = 1,
    D6 = 2,
    D8 = 3,
    D10 = 4,
    D12 = 5,
    D20 = 6
}