using System.Collections.Generic;
using UnityEngine;

namespace ProjectSaga
{
    public class ItemDataBaseObject : ScriptableObject, ISerializationCallbackReceiver
    {
        public ItemObject[] Items;
        public Dictionary<ItemObject, int> GetId = new Dictionary<ItemObject, int>();
        public void OnBeforeSerialize()
        {
            throw new System.NotImplementedException();
        }

        public void OnAfterDeserialize()
        {
            throw new System.NotImplementedException();
        }
    }    
}

