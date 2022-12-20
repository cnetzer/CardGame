using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "ScriptableObjects/Card")]
public class CardProperties : ScriptableObject
{
    [Header("Card Info")]
    public string cardName;
    [TextArea] public string description;
    public Texture2D texture;

    [Header("Hero Class")] 
    public HeroClass heroClass;

    [Header("Base Stats")] 
    [Range(0, 100)] public int health;
    [Range(0, 50)] public int defense;
    [Range(0, 100)] public int attack;
    [Range(0, 10)] public int cost;
}

public enum HeroClass
{
    None,
    Tank,
    Damage,
    Heal
}