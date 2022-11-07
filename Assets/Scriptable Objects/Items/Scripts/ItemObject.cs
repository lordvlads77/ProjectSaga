using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    Food,
    Equipment,
    Default
}

/*public enum Attributes
{
    Agility,
    Intellect,
    Stamina,
    Strength
}*/

public abstract class ItemObject : ScriptableObject
{
    public int Id;
    public Sprite uiDisplay;
    public ItemType type;
    [TextArea(15,20)]
    public string description;

}

[System.Serializable]
public class Item
{
    public string Name;
    public int Id;

    public Item(ItemObject item)
    {
        Name = item.name;
        Id = item.Id;
    }
}

/*public class ItemBuf
{
    public Attributes attributes;
    public int value;
    public int min;
    public int max;

    public ItemBuff(int _min, int _max)
    {
        min = _min;
        max = _max;
    }

    public void GenerateValue()
    {
        value = UnityEngine.Random.Range(min, max);
    }
}*/
