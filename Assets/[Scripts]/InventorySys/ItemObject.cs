using UnityEngine;

    public enum ItemType
    {
        Consumable,
        Weapons,
        Armor,
        Default
    }
    public abstract class ItemObject : ScriptableObject
    {
        public GameObject prefab = default;
        public ItemType type = default;
        [TextArea(15,20)]
        public string description;

    }    
