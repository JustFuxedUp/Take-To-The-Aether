using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    public int Zmin = -1;
    public int Xmin = -1;
    public int Zmax = 1;
    public int Xmax = 1;
    public void GridPosition(GameObject ent, int Xnum, int Znum)
    {
        // May be irrelevant later.
        bool Xeval; Xeval = ((Xmin <= Xnum) && (Xnum <= Xmax));
        bool Zeval; Zeval = ((Zmin <= Znum) && (Znum <= Zmax));
        bool goodcoords; goodcoords = (Xeval && Zeval);
        Debug.Log(Xeval.ToString() + Zeval.ToString() + goodcoords.ToString());
        switch (goodcoords)
        {
            case true:
                Vector3 newPos = new Vector3(0, 0, 0);
                int Xpos = Xnum;
                int Zpos = Znum;
                newPos = new Vector3(Xpos, 0, Zpos);
                ent.transform.position = newPos;
                break;
            case false:
                Debug.Log("coords not acceptable, out of bounds with coords " + Xnum.ToString() + "," + Znum.ToString());
                break;
        }
    }
}