using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    public class InventorySystem : MonoBehaviour
    {
        private Dictionary<inventoryItemData, InventoryItem> m_itemDictionary;
        public List<InventoryItem> inventory { get; private set; }

        private void Awake()
        {
            inventory = new List<InventoryItem>();
            m_itemDictionary = new Dictionary<inventoryItemData, InventoryItem>();
        }

        public InventoryItem Get(inventoryItemData referenceData)
        {
            if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
            {
                return value;
            }
            return null;
        }
        
        public void Add(inventoryItemData referenceData)
        {
            if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
            {
                value.AddToStack();
            }
            else
            {
                InventoryItem newItem = new InventoryItem(referenceData);
                inventory.Add(newItem);
                m_itemDictionary.Add(referenceData, newItem);
            }
        }

        public void Remove(inventoryItemData referenceData)
        {
            if (m_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
            {
                value.RemoveFromStack();
                if (value.stackSize == 0)
                {
                    inventory.Remove(value);
                    m_itemDictionary.Remove(referenceData);
                }
            }
        }
        
    }    
}

