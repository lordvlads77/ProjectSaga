using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectSaga;
using UnityEngine.Android;

public class Player : MonoBehaviour
{
    // TODO Remove the line of code 11 in the future if there is no more use for this by the 23-11
    //public MouseItem mouseItem = new MouseItem();
    
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
