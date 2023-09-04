using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Character Object", menuName = "Inventory System/items/Character")]
public class Characters : CharactersObjects
{
    public void Awake()
    {
        type = ItemType.Character;
    }
}
