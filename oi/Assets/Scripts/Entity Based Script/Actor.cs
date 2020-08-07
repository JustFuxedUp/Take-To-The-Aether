using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : Entity
{
    public int Hp { get; set; }
    public int Maxhp { get; set; }
    public int Basemaxhp { get; set; }
    public void TakeDamage(int damage)
    {
        Hp -= damage;
        Debug.Log(Name + "just got hit for " + damage.ToString());
    }
}
