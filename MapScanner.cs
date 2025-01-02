using System;
using DotsStorageManager.ECS;
using DotsStorageManager.StorageLevelMap;
using UnityEngine;

namespace DotsStorageManager
{
    public class MapScanner : MonoBehaviour
    {
        public float distance = 4.0f;
        public string mapKey = "";

        private StorageLevelMapManager _storageLevelMapManager;
        private LevelMapData _levelMapData;

        private void Awake()
        {
            _storageLevelMapManager = new(new StorageManger());
            _levelMapData = new();
        }

        public void SaveSceneMap()
        {
            _levelMapData.dots.Clear();
            _levelMapData.map_key = mapKey;

            for (int i = 0; i < transform.childCount; i++)
            {
                Transform dot = transform.GetChild(i);
                DotModel dotModel = new();

                var tmpName = dot.gameObject.name;
                if (tmpName.IndexOf("(") > 0)
                {
                    tmpName = tmpName.Remove(tmpName.IndexOf("("));
                }
                tmpName = tmpName.Replace(" ", "");
                dotModel.prefab_name = tmpName;
                dotModel.position_x = (int)(Math.Round(dot.transform.position.x) / distance);
                dotModel.position_y = (int)(Math.Round(dot.transform.position.y) / distance);

                _levelMapData.dots.Add(dotModel);
            }

            _storageLevelMapManager.SaveMap(mapKey, _levelMapData);
        }
    }
}