using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    public class InventoryItem
    {
        public inventoryItemData data { get; private set; }
        public int stackSize { get; private set; }

        public InventoryItem(inventoryItemData source)
        {
            data = source;
            AddToStack();
        }

        public void AddToStack()
        {
            stackSize++;
        }

        public void RemoveFromStack()
        {
            stackSize--;
        }
    }

}
