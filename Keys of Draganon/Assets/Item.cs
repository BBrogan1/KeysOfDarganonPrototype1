﻿
using UnityEngine;

[CreateAssetMenu(fileName = "new item", menuName = "Inventory/Item")]

public class Item : ScriptableObject
{
    new public string name = "new item";
    public Sprite icon = null;
    public bool isDefaultItem = false;

    public virtual void Use()
    {
        Debug.Log("Using" + name);
    }

    public void RemoveFromInventory()
    {
        Inventory.instance.Remove(this);
    }

}
