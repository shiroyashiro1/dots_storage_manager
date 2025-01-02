using System;
using System.Collections.Generic;
using DotsStorageManager.StorageData;

namespace DotsStorageManager.StorageLevelMap
{
    [Serializable]
    public class MapsList : IStorageData
    {
        public List<string> map_keys = new();

        public override string ToString()
        {
            return $"MapKeys: {map_keys}";
        }
    }
}