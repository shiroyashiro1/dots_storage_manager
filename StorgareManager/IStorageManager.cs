using System;
using DotsStorageManager.StorageData;

namespace DotsStorageManager
{
    public interface IStorageManager
    {
        public void SaveData(string key, IStorageData data, Action<bool> callback);
        public void LoadData(string key, Action<IStorageData> callback);
    }
}