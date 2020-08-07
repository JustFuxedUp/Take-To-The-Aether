using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityManager : MonoBehaviour
{
    public GameObject Unitmold;
    public GridManager _gridm;
    BlankUnit UnitData;

    enum UnitStats
    {
        Name,
        Description,
        Type,
        XPos,
        ZPos,
        HP,
        MaxHp,
        BaseMaxHp,
        Stamina,
        Speed,
        Initiative,
        BaseStamina,
        BaseSpeed,
        BaseInitiative
    }

    void Start()
    {
        GameObject FreshUnit = Instantiate(Unitmold, transform.position, transform.rotation);
        UnitData = FreshUnit.GetComponent<BlankUnit>();
        FreshUnit.name = "Trashman";
        Debug.Log(UnitData.ToString());
        for (int i = 0; i < Enum.GetNames(typeof(UnitStats)).Length; i++)
        {
            switch((int))
        }
        UnitData.ChangeString("name", "Trashman");
        UnitData.ChangeIntStat("stm", 2);
        UnitData.ChangeFloatStat("spd", 5);
        UnitData.ChangeFloatStat("init", 6);
        UnitData.ChangePos(1, 1);
        _gridm.GridPosition(FreshUnit, 1, 1);

        Debug.Log("Started with creating a " + UnitData._stats.Name + " with type " + UnitData._stats.Type + "with " + UnitData._stats.Hp.ToString() + " out of " +
        UnitData._stats.Maxhp.ToString() + ". It has " + UnitData._stats.Initiative.ToString() + " INI, " + UnitData._stats.Speed.ToString() + " SPD, " + UnitData._stats.Stamina.ToString() +
        " STA,  at pos" + UnitData._stats.XPos.ToString() + "," + UnitData._stats.ZPos.ToString());
    }

    public void CreateNewUnit(string name, string type, int xpos, int zpos, int hp, int maxhp, int basemaxhp, int stm, int basestm, float spd, float basespd, float init, float baseinit)
    {
        GameObject FreshUnit = Instantiate(Unitmold, transform.position, transform.rotation);
        UnitData = FreshUnit.GetComponent<BlankUnit>();
        FreshUnit.name = name;
        Debug.Log(UnitData.ToString());
        UnitData.ChangeString("name", name);
        UnitData.ChangeIntStat("stm", stm);
        UnitData.ChangeFloatStat("spd", spd);
        UnitData.ChangeFloatStat("init", init);
        _gridm.GridPosition(FreshUnit, xpos, zpos);

        Debug.Log("Created a " + UnitData._stats.Name + " with type " + UnitData._stats.Type + "with " + UnitData._stats.Hp.ToString() + " out of " +
        UnitData._stats.Maxhp.ToString() + ". It has " + UnitData._stats.Initiative.ToString() + " INI, " + UnitData._stats.Speed.ToString() + " SPD, " + UnitData._stats.Stamina.ToString() +
        " STA,  at pos" + UnitData._stats.XPos.ToString() + "," + UnitData._stats.ZPos.ToString());
    }
}
