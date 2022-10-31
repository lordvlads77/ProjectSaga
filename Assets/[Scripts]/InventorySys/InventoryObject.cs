using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEditor;
using UnityEngine;

namespace ProjectSaga
{
    [CreateAssetMenu (fileName = "New Inventory", menuName = "Inventory System/Inventory")]
    public class InventoryObject : ScriptableObject, ISerializationCallbackReceiver
    {
        public string _savePath = default;
        private ItemDataBaseObject databaseObject;
        public List<InventorySlot> _Container = new List<InventorySlot>();

        private void OnEnable()
        {
#if UNITY_EDITOR
            
            databaseObject =
                (ItemDataBaseObject) AssetDatabase.LoadAssetAtPath(
                    "Assets/Resources/ItemsDataBase.asset", typeof(ItemDataBaseObject));
#else
            databaseObject = Resources.Load<ItemDataBaseObject>("ItemDataBase");
#endif
        }

        public void AddItem(ItemObject _item, int _amount)
        {
            for (int i = 0; i < _Container.Count; i++)
            {
                if (_Container[i]._itemObject == _item)
                {
                    _Container[i].AddAmount(_amount);
                    return;
                }
            }
            _Container.Add(new InventorySlot(databaseObject.GetId[_item], _item, _amount));   
            
        }

        public void Save()
        {
            string _saveData = JsonUtility.ToJson(this, true);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = File.Create(string.Concat(Application.persistentDataPath, _savePath));
            binaryFormatter.Serialize(fileStream, _saveData);
            fileStream.Close();
        }

        public void Load()
        {
            if (File.Exists(string.Concat(Application.persistentDataPath, _savePath)))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                FileStream fileStream =
                    File.Open(string.Concat(Application.persistentDataPath, _savePath), FileMode.Open);
                JsonUtility.FromJsonOverwrite(binaryFormatter.Deserialize(fileStream).ToString(), this);
                fileStream.Close();
            }
        }

        public void OnBeforeSerialize()
        {
        }

        public void OnAfterDeserialize()
        {
            for (int i = 0; i < _Container.Count; i++)
            {
                _Container[i]._itemObject = databaseObject._getItem[_Container[i]._ID_];
            }
        }
    }

    [System.Serializable]
    public class InventorySlot
    {
        public int _ID_ = default;
        [SerializeField] public ItemObject _itemObject;
        [SerializeField] public int _amount_ = default;

        public InventorySlot(int _id, ItemObject _item, int _amount)
        {
            _ID_ = _id;
            _itemObject = _item;
            _amount_ = _amount;
        }

        public void AddAmount(int _value)
        {
            _amount_ += _value;
        }
        
    }
}

