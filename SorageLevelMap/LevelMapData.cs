using System;
using System.Collections.Generic;
using DotsStorageManager.ECS;
using DotsStorageManager.StorageData;

namespace DotsStorageManager.StorageLevelMap
{
    [Serializable]
    public class LevelMapData : IStorageData
    {
        public string map_key;
        public List<DotModel> dots = new();

        public override string ToString()
        {
            return $"MapKey: {map_key}, Dots: [{String.Join(", ", dots)}]";
        }
    }
}