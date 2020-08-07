using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Cards : ScriptableObject
{
    public new string name;
    public string description;
    public int type;

    public Sprite artwork;

    public int cost;
    public int rarity;
}
