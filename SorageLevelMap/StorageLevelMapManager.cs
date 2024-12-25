using System.Collections.Generic;
using UnityEngine;

namespace DotsStorageManager.StorageLevelMap
{
    public class StorageLevelMapManager
    {
        public LevelMapData CurrentLevelMap { get; set; }
        public StorageManger storageManger;

        public StorageLevelMapManager(StorageManger storage)
        {
            storageManger = storage;
        }

        public void SaveMap(string key, LevelMapData level)
        {
            storageManger.SaveData(key, level, SaveHandler);
        }

        public void LoadMap(string key)
        {
            storageManger.LoadData<LevelMapData>(key, LoadHandler);
        }

        public List<string> LoadMapsList()
        {
            List<string> maps = new();
            
            storageManger.LoadData<MapsList>("all", (val) => {
                maps = val.MapKeys;
            });

            return maps;
        }

        private void SaveHandler(bool success)
        {
            if (success)
            {
                Debug.Log(success);
            }
        }

        private void LoadHandler(LevelMapData level)
        {
            CurrentLevelMap = level;
        }
    }
}