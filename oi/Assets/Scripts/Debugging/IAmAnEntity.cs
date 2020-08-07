using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAmAnEntity : MonoBehaviour
{
    public GridManager _gridm;
    private Unit Warrior = new Unit();

    private void Start()
    {
        Warrior.Name = "Cherry";
        Warrior.Type = "Unit";
        Warrior.XPos = 1;
        Warrior.ZPos = 1;
        Warrior.Hp = 1;
        Warrior.Maxhp = 2;
        _gridm = FindObjectOfType<GridManager>();

        Debug.Log("This entity called " + Warrior.Name + " is a " + Warrior.Type + " in position " + Warrior.XPos.ToString() + "," + Warrior.ZPos.ToString());

        Warrior.TakeDamage(1);
        Debug.Log("Unit " + Warrior.Name + " HP is " + Warrior.Hp.ToString() + " out of " + Warrior.Maxhp.ToString());

        _gridm.GridPosition(this.gameObject, Warrior.XPos - 1, Warrior.ZPos);
        _gridm.GridPosition(this.gameObject, 5, -5);
    }
}
