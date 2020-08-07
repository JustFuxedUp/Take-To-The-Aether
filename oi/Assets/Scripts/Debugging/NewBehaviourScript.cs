using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private void Start()
    {
        Unit Warrior = new Unit();
        Warrior.Name = "YumYum";
        Warrior.Type = "Unit";
        Warrior.XPos = -1;
        Warrior.ZPos = -1;
        Warrior.Hp = 1;
        Warrior.Maxhp = 2;

        Debug.Log("This entity called " + Warrior.Name + " is a " + Warrior.Type + " in position " + Warrior.XPos.ToString() + "," + Warrior.ZPos.ToString());

        Warrior.TakeDamage(1);
        Debug.Log("Unit " + Warrior.Name + " HP is " + Warrior.Hp.ToString() + " out of " + Warrior.Maxhp.ToString());
    }
}
