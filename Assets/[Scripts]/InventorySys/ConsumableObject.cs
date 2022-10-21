using UnityEngine;

namespace ProjectSaga
{
    [CreateAssetMenu(fileName = "New Consumable Object", menuName = "Inventory System/Items/Consumables")]
    public class ConsumableObject : ItemObject
    {
        [SerializeField] public int _restoreAmountHP = default;
        public void Awake()
        {
            type = ItemType.Consumable;   
        }
    }    
}

