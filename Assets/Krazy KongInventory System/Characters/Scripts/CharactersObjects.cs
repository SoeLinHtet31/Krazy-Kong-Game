 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Character,
    Weapons,
    Material,
    Default
}

public abstract class CharactersObjects : ScriptableObject
{
    public GameObject prefeb;
    public ItemType type;
    [TextArea(15,20)]
    public string description;
}
