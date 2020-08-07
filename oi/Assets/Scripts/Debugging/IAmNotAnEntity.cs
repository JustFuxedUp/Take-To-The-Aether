using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAmNotAnEntity : MonoBehaviour
{
    public GridManager themanager;
    void Start()
    {
        themanager = FindObjectOfType<GridManager>();
        themanager.GridPosition(this.gameObject, 1, 1);
    }
}
