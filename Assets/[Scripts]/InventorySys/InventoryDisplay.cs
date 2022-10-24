using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

namespace ProjectSaga
{
    public class InventoryDisplay : MonoBehaviour
    {
        [SerializeField] private int _xStart = default;
        [SerializeField] private int _yStart = default;
        public InventoryObject inventoryObject = default;
        [SerializeField] private int _xSpaceBetweenItem = default;
        [SerializeField] private int _numOfColumns = default;
        [SerializeField] private int _ySpaceBetweenItem = default;
        private Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();
        void Start()
        {
            CreateInventory();
        }

        // Update is called once per frame
        void Update()
        {
            UpdateInventory();
        }
        
        public void CreateInventory()
        {
            for (int i = 0; i < inventoryObject._Container.Count; i++)
            {
                var obj = Instantiate(inventoryObject._Container[i]._itemObject.prefab, Vector3.zero,
                    Quaternion.identity, transform);
                obj.GetComponent<RectTransform>().localPosition = getLocalPos(i);
                obj.GetComponentInChildren<TextMeshProUGUI>().text =
                    inventoryObject._Container[i]._amount_.ToString("n0");
                
                itemsDisplayed.Add(inventoryObject._Container[i], obj);
            }
        }

        public Vector3 getLocalPos(int i)
        {
            return new Vector3(_xStart + ( _xSpaceBetweenItem * (i % _numOfColumns)), _yStart + (-_ySpaceBetweenItem * (i / _numOfColumns)),
                0f);
            
        }

        public void UpdateInventory()
        {
            for (int i = 0; i < inventoryObject._Container.Count; i++)
            {
                if (itemsDisplayed.ContainsKey(inventoryObject._Container[i]))
                {
                    itemsDisplayed[inventoryObject._Container[i]].GetComponentInChildren<TextMeshProUGUI>().text =
                        inventoryObject._Container[i]._amount_.ToString("n0");
                }
                else
                {
                     var obj = Instantiate(inventoryObject._Container[i]._itemObject.prefab, Vector3.zero,
                    Quaternion.identity, transform);
                    obj.GetComponent<RectTransform>().localPosition = getLocalPos(i);
                    obj.GetComponentInChildren<TextMeshProUGUI>().text =
                    inventoryObject._Container[i]._amount_.ToString("n0");
                    itemsDisplayed.Add(inventoryObject._Container[i], obj);
                }
            }
        }
    }   
}
