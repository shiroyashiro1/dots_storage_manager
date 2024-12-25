using System;
using System.IO;
using DotsStorageManager.StorageData;
using UnityEngine;

namespace DotsStorageManager
{
    public class StorageManger : IStorageManager
    {
        public void LoadData(string key, Action<IStorageData> callback)
        {
            string path = BuildPath(key);
            string json = "";

            using (var fileStream = new StreamReader(path))
            {
                json = fileStream.ReadToEnd();
            }
            
            IStorageData data = JsonUtility.FromJson<IStorageData>(json);

            callback?.Invoke(data);
        }

        public void SaveData(string key, IStorageData data, Action<bool> callback)
        {
            string path = BuildPath(key);
            string json = JsonUtility.ToJson(data);
            
            using (var fileStream = new StreamWriter(path))
            {
                fileStream.Write(json);
            }

            callback?.Invoke(true);
        }

        private string BuildPath(string key)
        {
            return Path.Combine(Application.persistentDataPath, key);
        }
    }
}