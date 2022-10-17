using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    [CreateAssetMenu(menuName = "Inventory Item Data")]
    public class inventoryItemData : ScriptableObject
    {
        public string _id = default;
        public string _displayName = default;
        public Sprite _icon = default;
        public GameObject _prefab = default;
    }    
}

