using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Unit", menuName = "Unit")]
public class Units : ScriptableObject
{
    public new string name;
    public string description;
    public int type;

    public int XPos;
    public int ZPos;

    public int hp;
    public int maxhp;
    public int basemaxhp;

    public int stamina;
    public float speed;
    public float initiative;

    public int basestamina;
    public float basespeed;
    public float baseinitiative;

    public Sprite artwork;
}
