using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    [CreateAssetMenu (fileName = "New Inventory", menuName = "Inventory System/Inventory")]
    public class InventoryObject : ScriptableObject
    {
        public List<InventorySlot> _Container = new List<InventorySlot>();

        public void AddItem(ItemObject _item, int _amount)
        {
            bool _hasItem = false;
            for (int i = 0; i < _Container.Count; i++)
            {
                if (_Container[i]._itemObject == _item)
                {
                    _Container[i].AddAmount(_amount);
                    _hasItem = true;
                    break;
                }
            }

            if (!_hasItem)
            {
                _Container.Add(new InventorySlot(_item, _amount));   
            }
        }
    }

    [System.Serializable]
    public class InventorySlot
    {
        [SerializeField] public ItemObject _itemObject;
        [SerializeField] public int _amount_ = default;

        public InventorySlot(ItemObject _item, int _amount)
        {
            _itemObject = _item;
            _amount_ = _amount;
        }

        public void AddAmount(int _value)
        {
            _amount_ += _value;
        }
        
    }
}

