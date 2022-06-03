namespace PlayerCard.Model;

public record PlayerCard
{
    public Guid Id { get; set; }
    
    public string? CharacterName { get; set; }
    
    public CharacterInfo? CharacterInfo { get; set; }

    public static Characteristic Strength { get; set; } =
        new Characteristic(
            "Strength",
            new List<Skill>
            {
                new ("Athletics")
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
}

public record Skill(string? Name)
{
    public string? Name { get; }
    
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
    
}

public enum Dice
{
    
}