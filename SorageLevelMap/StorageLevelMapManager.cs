using System;
using UnityEngine;

namespace DotsStorageManager.StorageLevelMap
{
    public class StorageLevelMapManager
    {
        public LevelMapData CurrentLevelMap { get; set; }
        private StorageManger _storageManger;
        private MapsList _mapsList;
        private readonly string folderMap = "Assets/dots_storage_manager/level_map/";
        private readonly string filenameMapsKeys = "Assets/dots_storage_manager/keys_map";

        public StorageLevelMapManager(StorageManger storageManger)
        {
            _storageManger = storageManger;
            CurrentLevelMap = new();
            _mapsList = new();
            _mapsList = LoadMapsList();
        }

        public void SaveMap(string key, LevelMapData level)
        {
            _storageManger.SaveData(folderMap + key, level, SaveHandler);
            if (!MapKeyCheck(key))
            {
                SaveMapsKeysList(key);
            }
        }

        public void LoadMap(string key)
        {
            if (!MapKeyCheck(key))
                throw new Exception($"Map key '{key}' don't exist.");
            
            _storageManger.LoadData<LevelMapData>(folderMap + key, LoadHandler);
        }

        public MapsList LoadMapsList()
        {            
            _storageManger.LoadData<MapsList>(filenameMapsKeys, (val) => {
                _mapsList = val;
            });

            return _mapsList;
        }

        public void SaveMapsKeysList(string new_key)
        {
            _mapsList.map_keys.Add(new_key);
            
            _storageManger.SaveData(filenameMapsKeys, _mapsList, (success) => {
                if (success)
                    Debug.Log($"New key '{new_key}' is saved.");
            });
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

        private bool MapKeyCheck(string key)
        {
            if (_mapsList.map_keys.Contains(key)) {
                return true;
            }
            return false;
        }
    }
}