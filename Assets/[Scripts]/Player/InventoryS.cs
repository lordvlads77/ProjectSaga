using System;
using UnityEngine;

namespace ProjectSaga
{
    public class InventoryS : MonoBehaviour
    {
        [SerializeField] public InventoryObject _inventory = default;


        public void OnTriggerEnter(Collider other)
        {
            var _itemm = other.GetComponent<Item>();
            if (_itemm)
            {
                _inventory.AddItem(_itemm._itemm, 1);
                Destroy(other.gameObject);
            }
        }

        private void OnApplicationQuit()
        {
            _inventory._Container.Clear();
        }
    }    
}

