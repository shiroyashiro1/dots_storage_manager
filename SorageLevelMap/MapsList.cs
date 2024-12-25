using System;
using System.Collections.Generic;
using DotsStorageManager.StorageData;

namespace DotsStorageManager.StorageLevelMap
{
    [Serializable]
    public class MapsList : IStorageData
    {
        public List<string> MapKeys { get; }

        public MapsList() { MapKeys = new(); }
    }
}