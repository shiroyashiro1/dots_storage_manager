using DotsStorageManager.StorageLevelMap;
using UnityEngine;

namespace DotsStorageManager
{
    public class MapGenerator : MonoBehaviour
    {
        private StorageLevelMapManager _storageLevelMapManager;
        private LevelMapData _currentLevelMapData;

        public float distance = 4.0f;
        public string mapKey = "";

        private void Awake()
        {
            _storageLevelMapManager = new(new StorageManger());
        }

        public void LoadLevel(string map_key)
        {
            mapKey = map_key;
            _storageLevelMapManager.LoadMap(mapKey);
            _currentLevelMapData = _storageLevelMapManager.CurrentLevelMap;
        }

        public void LoadLevelToScene()
        {
            Debug.Log($"Load Level To Scene");
            foreach (var dot in _currentLevelMapData.dots)
            {
                Debug.Log($"dot: {dot}");
                var prefab = Resources.Load<GameObject>($"Prefabs/{dot.prefab_name}");
                Debug.Log($"prefab: {prefab}");
                var tmpP = Instantiate(prefab);

                tmpP.transform.parent = this.transform;
                tmpP.transform.position = new Vector2(dot.position_x, dot.position_y) * distance;
            }
        }
    }
}