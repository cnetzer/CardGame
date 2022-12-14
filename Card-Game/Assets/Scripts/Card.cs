using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    [Header("Card Info")]
    public string cardName = "Card Name";
    [TextArea] public string cardDescription = "This is a description";
    public int id = -1;

    [Header("Stats")] 
    public int attack = 0;
    public int health = 1;
    public int cost = 0;

    [Header("Attributes")] public List<Attributes> attributes;
}

public enum Attributes
{
    
}