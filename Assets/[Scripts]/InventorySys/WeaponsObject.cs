using UnityEngine;

namespace ProjectSaga
{
    [CreateAssetMenu (fileName = "New Weapons Object", menuName = "Inventory System/Items/Weapons")]
    public class WeaponsObject : ItemObject
    {
        [SerializeField] private float _attckStat = default;
        [SerializeField] private float _defenceStat = default;
        public void Awake()
        {
            type = ItemType.Weapons;
        }
    }    
}

