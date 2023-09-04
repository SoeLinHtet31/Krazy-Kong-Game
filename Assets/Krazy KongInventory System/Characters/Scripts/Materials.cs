using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Material Object", menuName = "Inventory System/items/Material")]
public class Materials : CharactersObjects
{
    public void Awake()
    {
        type = ItemType.Material;
    }
}
