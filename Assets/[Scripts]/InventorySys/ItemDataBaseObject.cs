using System.Collections.Generic;
using UnityEngine;

    [CreateAssetMenu(fileName = "New Item Database", menuName = "Inventory System/Items/Database")]
    public class ItemDataBaseObject : ScriptableObject, ISerializationCallbackReceiver
    {
        [SerializeField] public ItemObject[] Items;
        public Dictionary<ItemObject, int> GetId = new Dictionary<ItemObject, int>();
        public Dictionary<int, ItemObject> _getItem = new Dictionary<int, ItemObject>();
        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            GetId = new Dictionary<ItemObject, int>();
            _getItem = new Dictionary<int, ItemObject>();
            for (int i = 0; i < Items.Length; i++)
            {
                GetId.Add(Items[i], i);
                _getItem.Add(i, Items[i]);
            }
        }
    }    


