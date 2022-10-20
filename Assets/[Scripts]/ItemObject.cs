using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    public enum ItemType
    {
        Food,
        Equipment,
        Default
    }
    public abstract class ItemObject : ScriptableObject
    {
        public GameObject prefab = default;
        public ItemType type = default;
        [TextArea(15,20)]
        public string description;

    }    
}
