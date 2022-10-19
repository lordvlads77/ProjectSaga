using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    public class ItemObject : MonoBehaviour
    {
        public inventoryItemData referenceItem;

        public void OnHandlePickupItem()
        {
            //InventorySystem.current.Add(referenceItem);
            Destroy(gameObject);
        }
    }    
}
