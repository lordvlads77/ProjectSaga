using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectSaga;

public class Player : MonoBehaviour
{
    public MouseItem mouseItem = new MouseItem();
    
    public PlayerActions _playerActions;
    public InventoryObject inventory;

    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<GroundItem>();
        if (item)
        {
            inventory.AddItem(new Item(item.item), 1);
            Destroy(other.gameObject);
        }
    }
    

    private void OnApplicationQuit()
    {
        inventory.Container.Items = new InventorySlot[16];
    }
}
