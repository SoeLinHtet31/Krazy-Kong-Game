using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Default Object", menuName = "Inventory System/items/Default")]
public class DefaultObject : CharactersObjects
{
    public void Awake()
    {
        type = ItemType.Default;
    }
}
