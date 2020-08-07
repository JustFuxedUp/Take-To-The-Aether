using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;

public class BlankUnit : MonoBehaviour
{
    public Unit _stats = new Unit();

    public void ChangePos(int xpos, int  zpos)
    {
        _stats.XPos = xpos;
        _stats.ZPos = zpos;
    }

    public void ChangeString(string stat, string value)
    {
        switch (stat)
        {   
            case "name":
                string name = _stats.Name;
                Debug.Log("Unit " + name + " Has changed their name to " + value);
                _stats.Name = value;
                break;
            default:
                Debug.LogError("Error! Tried to write a value for a string that doesn't exist! Target stat was labelled " + stat + ", trying to write with " + value);
                break;
        }
    }

    public void ChangeIntStat(string stat, int value)
    {
        switch (stat)
        {
            case "stm":
                int stm = _stats.Stamina;
                Debug.Log("Unit " + _stats.Name + " Has changed their stamina value from " + stm + " to " + value);
                _stats.Stamina = value;
                break;
            case "bstm":
                int bstm = _stats.Basestamina;
                Debug.Log("Unit " + _stats.Name + " Has changed their stamina value from " + bstm + " to " + value);
                _stats.Basestamina = value;
                break;
            default:
                Debug.LogError("Error! Tried to write a value for an int stat that doesn't exist! Target stat was labelled " + stat + ", trying to write with " + value);
                break;
        }
    }

    public void ChangeFloatStat(string stat, float value)
    {
        switch (stat)
        {
            case "spd":
                float spd = _stats.Speed;
                Debug.Log("Unit " + _stats.Name + " Has changed their speed value from " + spd + " to " + value);
                _stats.Speed = value;
                break;
            case "bspd":
                float bspd = _stats.Basespeed;
                Debug.Log("Unit " + _stats.Name + " Has changed their base speed value from " + bspd + " to " + value);
                _stats.Speed = value;
                break;
            case "init":
                float init = _stats.Initiative;
                Debug.Log("Unit " + _stats.Name + " Has changed their initiative value from " + init + " to " + value);
                _stats.Initiative = value;
                break;
            case "binit":
                float binit = _stats.Initiative;
                Debug.Log("Unit " + _stats.Name + " Has changed their base initiative value from " + binit + " to " + value);
                _stats.Initiative = value;
                break;
            default:
                Debug.LogError("Error! Tried to write a value for a float stat that doesn't exist! Target stat was labelled " + stat + ", trying to write with " + value);
                break;
        }
    }
}
