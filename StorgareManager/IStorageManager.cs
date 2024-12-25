using System;
using DotsStorageManager.StorageData;

namespace DotsStorageManager
{
    public interface IStorageManager
    {
        public void SaveData(string key, IStorageData data, Action<bool> callback);
        public void LoadData<T>(string key, Action<T> callback) where T : IStorageData;
    }
}