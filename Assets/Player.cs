using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ProjectSaga;

public class Player : MonoBehaviour
{
    public PlayerActions _playerActions;
    public InventoryObject inventory;

    public void OnTriggerEnter(Collider other)
    {
        var item = other.GetComponent<Item>();
        if (item)
        {
            inventory.AddItem(item.item, 1);
            Destroy(other.gameObject);
        }
    }
    

    private void OnApplicationQuit()
    {
        //inventory.Container.Clear();
    }
}
