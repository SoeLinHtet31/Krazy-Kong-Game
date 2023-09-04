using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Weapons Object", menuName = "Inventory System/items/Weapons")]
public class Weapons : CharactersObjects
{
    public void Awake()
    {
        type = ItemType.Weapons;
    }
}
