using System;
using System.IO;
using DotsStorageManager.StorageData;
using UnityEngine;

namespace DotsStorageManager
{
    public class StorageManger : IStorageManager
    {
        public void LoadData<T>(string key, Action<T> callback) where T : IStorageData
        {
            string path = BuildPath(key);
            string json = "";

            using (var fileStream = new StreamReader(path))
            {
                Debug.Log($"Read json file ({path})");
                json = fileStream.ReadToEnd();
            }

            // Debug.Log($"Load json: {json}");

            T data = JsonUtility.FromJson<T>(json);
            callback?.Invoke(data);
        }

        public void SaveData(string key, IStorageData data, Action<bool> callback)
        {
            string path = BuildPath(key);
            string json = JsonUtility.ToJson(data);
            Debug.Log($"json: {json}");
            
            using (var fileStream = new StreamWriter(path))
            {
                fileStream.Write(json);
            }

            callback?.Invoke(true);
        }

        private string BuildPath(string key)
        {
            return Path.Combine(System.IO.Directory.GetCurrentDirectory(), key + ".json");
        }
    }
}